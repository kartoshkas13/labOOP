using System;
using System.Runtime.Serialization;

namespace lab14
{
    [DataContract]
    public class GuestBookRecord : IComparable<GuestBookRecord>, ICloneable
    {
        private string _fullName;
        private DateTime _arrivalTime;
        private DateTime _departureTime;
        private int _roomNumber;

        public GuestBookRecord()
            : this("Невідомий відвідувач", DateTime.Now, DateTime.Now.AddHours(1), 1)
        {
        }

        public GuestBookRecord(string fullName, DateTime arrivalTime, DateTime departureTime, int roomNumber)
        {
            try
            {
                FullName = fullName;
                ArrivalTime = arrivalTime;
                DepartureTime = departureTime;
                RoomNumber = roomNumber;
                Validate();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Помилка створення запису гостьової книги: " + ex.Message, ex);
            }
        }

        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ПІБ не може бути порожнім.");

                _fullName = value.Trim();
            }
        }

        [DataMember]
        public DateTime ArrivalTime
        {
            get { return _arrivalTime; }
            set
            {
                _arrivalTime = value;
            }
        }

        [DataMember]
        public DateTime DepartureTime
        {
            get { return _departureTime; }
            set
            {
                _departureTime = value;
            }
        }

        [DataMember]
        public int RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер кімнати повинен бути додатним числом.");

                _roomNumber = value;
            }
        }

        public double HoursInHotel
        {
            get { return (DepartureTime - ArrivalTime).TotalHours; }
        }

        public bool StayedMoreThanHour()
        {
            return HoursInHotel > 1;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(_fullName))
                throw new ArgumentException("ПІБ не може бути порожнім.");

            if (_roomNumber <= 0)
                throw new ArgumentException("Номер кімнати повинен бути додатним числом.");

            if (_arrivalTime >= _departureTime)
                throw new ArgumentException("Дата прибуття повинна бути раніше дати виходу з готелю.");
        }

        public string GetInfo()
        {
            return string.Format(
                "{0}; прибув: {1:g}; покинув: {2:g}; номер: {3}; перебував: {4:0.##} год.",
                FullName,
                ArrivalTime,
                DepartureTime,
                RoomNumber,
                HoursInHotel);
        }

        public int CompareTo(GuestBookRecord other)
        {
            if (other == null)
                return 1;

            int roomCompare = RoomNumber.CompareTo(other.RoomNumber);
            if (roomCompare != 0)
                return roomCompare;

            return string.Compare(FullName, other.FullName, StringComparison.CurrentCultureIgnoreCase);
        }

        public object Clone()
        {
            return new GuestBookRecord(FullName, ArrivalTime, DepartureTime, RoomNumber);
        }
    }
}
