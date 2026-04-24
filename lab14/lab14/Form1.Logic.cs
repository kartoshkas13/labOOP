using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1
    {
        private GuestBookCollection _guestBook;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            EnsureGuestBook();
            SetDefaultInputValues();
            _guestBook.FillDemoData();
            ShowRecords(_guestBook.Records, "Усі записи гостьової книги");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureGuestBook();
                GuestBookRecord record = new GuestBookRecord(
                    txtFullName.Text,
                    dtpArrival.Value,
                    dtpDeparture.Value,
                    Convert.ToInt32(nudRoom.Value));

                _guestBook.Add(record);
                ShowRecords(_guestBook.Records, "Запис додано. Показано всі записи");
                SetDefaultInputValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Некоректні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            EnsureGuestBook();
            _guestBook.FillDemoData();
            ShowRecords(_guestBook.Records, "Демо-дані завантажено");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            EnsureGuestBook();
            ShowRecords(_guestBook.Records, "Усі записи гостьової книги");
        }

        private void btnFilterSort_Click(object sender, EventArgs e)
        {
            EnsureGuestBook();
            ShowRecords(
                _guestBook.GetVisitorsMoreThanHourSortedByRoom(),
                "Відвідувачі, які перебували більше години. Сортування за номером");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EnsureGuestBook();
            _guestBook.Clear();
            ShowRecords(_guestBook.Records, "Колекцію очищено");
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureGuestBook();

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Title = "Зберегти серіалізовані дані";
                    sfd.Filter = "XML files (*.xml)|*.xml";
                    sfd.FileName = "guest_book.xml";
                    sfd.InitialDirectory = Application.StartupPath;

                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    _guestBook.SaveToXml(sfd.FileName);
                    lblStatus.Text = "Серіалізацію виконано. Дані збережено у " + Path.GetFileName(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося виконати серіалізацію: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureGuestBook();

                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = "Завантажити серіалізовані дані";
                    ofd.Filter = "XML files (*.xml)|*.xml";
                    ofd.InitialDirectory = Application.StartupPath;

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    _guestBook.LoadFromXml(ofd.FileName);
                    ShowRecords(_guestBook.Records, "Дані успішно десеріалізовано з XML");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося виконати десеріалізацію: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureGuestBook();

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Title = "Зберегти дані у JSON";
                    sfd.Filter = "JSON files (*.json)|*.json";
                    sfd.FileName = "guest_book.json";
                    sfd.InitialDirectory = Application.StartupPath;

                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    _guestBook.SaveToJson(sfd.FileName);
                    lblStatus.Text = "JSON збережено у " + Path.GetFileName(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зберегти JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureGuestBook();

                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = "Завантажити дані з JSON";
                    ofd.Filter = "JSON files (*.json)|*.json";
                    ofd.InitialDirectory = Application.StartupPath;

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    _guestBook.LoadFromJson(ofd.FileName);
                    ShowRecords(_guestBook.Records, "Дані успішно десеріалізовано з JSON");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося завантажити JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnsureGuestBook()
        {
            if (_guestBook == null)
                _guestBook = new GuestBookCollection();
        }

        private void ShowRecords(IEnumerable<GuestBookRecord> records, string status)
        {
            DataTable data = CreateGuestTable();

            foreach (GuestBookRecord record in records)
            {
                data.Rows.Add(
                    record.FullName,
                    record.ArrivalTime.ToString("dd.MM.yyyy HH:mm"),
                    record.DepartureTime.ToString("dd.MM.yyyy HH:mm"),
                    record.RoomNumber,
                    string.Format("{0:0.##} год.", record.HoursInHotel),
                    record.StayedMoreThanHour() ? "Так" : "Ні");
            }

            dgvGuests.DataSource = data;
            lblStatus.Text = string.Format("{0}. Записів: {1}", status, data.Rows.Count);
        }

        private DataTable CreateGuestTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ПІБ");
            table.Columns.Add("Прибув");
            table.Columns.Add("Покинув");
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Тривалість");
            table.Columns.Add("Більше години");
            return table;
        }

        private void SetDefaultInputValues()
        {
            txtFullName.Text = string.Empty;
            dtpArrival.Value = DateTime.Now;
            dtpDeparture.Value = DateTime.Now.AddHours(2);
            nudRoom.Value = 101;
            txtFullName.Focus();
        }
    }
}
