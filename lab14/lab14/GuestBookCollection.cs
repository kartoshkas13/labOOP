using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace lab14
{
    public class GuestBookCollection : IEnumerable<GuestBookRecord>
    {
        private readonly BindingList<GuestBookRecord> _records = new BindingList<GuestBookRecord>();

        public BindingList<GuestBookRecord> Records
        {
            get { return _records; }
        }

        public void Add(GuestBookRecord record)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record), "Запис не може бути порожнім.");

            record.Validate();
            _records.Add(record);
        }

        public void Clear()
        {
            _records.Clear();
        }

        public void FillDemoData()
        {
            Clear();
            Add(new GuestBookRecord("Іваненко Андрій Петрович", DateTime.Today.AddHours(8), DateTime.Today.AddHours(8).AddMinutes(45), 203));
            Add(new GuestBookRecord("Петренко Олена Василівна", DateTime.Today.AddHours(9), DateTime.Today.AddHours(11).AddMinutes(15), 101));
            Add(new GuestBookRecord("Шевченко Марія Ігорівна", DateTime.Today.AddHours(10), DateTime.Today.AddHours(13), 305));
            Add(new GuestBookRecord("Коваленко Дмитро Сергійович", DateTime.Today.AddHours(12), DateTime.Today.AddHours(12).AddMinutes(50), 101));
            Add(new GuestBookRecord("Бондар Назар Олегович", DateTime.Today.AddHours(14), DateTime.Today.AddHours(16).AddMinutes(20), 203));
        }

        public BindingList<GuestBookRecord> GetVisitorsMoreThanHourSortedByRoom()
        {
            var filtered = _records
                .Where(record => record.StayedMoreThanHour())
                .OrderBy(record => record)
                .ToList();

            return new BindingList<GuestBookRecord>(filtered);
        }

        public string Display()
        {
            if (_records.Count == 0)
                return "Колекція порожня.";

            var builder = new StringBuilder();
            foreach (GuestBookRecord record in _records)
                builder.AppendLine(record.GetInfo());

            return builder.ToString();
        }

        public void SaveToXml(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Шлях до файлу не вказано.");

            var serializer = new XmlSerializer(typeof(List<GuestBookRecord>));
            var records = _records.ToList();

            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, records);
            }
        }

        public void LoadFromXml(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Шлях до файлу не вказано.");
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл серіалізації не знайдено.", filePath);

            var serializer = new XmlSerializer(typeof(List<GuestBookRecord>));

            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var records = (List<GuestBookRecord>)serializer.Deserialize(fs);
                Clear();

                foreach (GuestBookRecord record in records)
                    Add(record);
            }
        }

        public void SaveToJson(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Шлях до файлу не вказано.");

            var records = _records.ToList();
            string json = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(filePath, json, Encoding.UTF8);
        }

        public void LoadFromJson(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Шлях до файлу не вказано.");
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл серіалізації не знайдено.", filePath);

            string json = File.ReadAllText(filePath, Encoding.UTF8);
            var records = JsonConvert.DeserializeObject<List<GuestBookRecord>>(json);

            if (records == null)
                throw new InvalidOperationException("Не вдалося прочитати JSON-файл.");

            Clear();

            foreach (GuestBookRecord record in records)
                Add(record);
        }

        public IEnumerator<GuestBookRecord> GetEnumerator()
        {
            return _records.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
