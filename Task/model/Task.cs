using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.model
{
    public class TblTask : BaseUser
    {
        public TypeDepartment TypeDepartment { get; set; }
        public TypeTask TypeTask { get; set; }
        public List<TblTaskAddress> TaskAddress { get; set; }
        public List<TblTaskItems> TaskItems { get; set; }
        public List<TblTaskConnection> TaskConnections { get; set; }
    }
    public class TblTaskAddress : BaseUser
    {
        public TypeAddress TypeAddress { get; set; }
        public int City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string Apartment { get; set; }
        public int Floor { get; set; }
        public bool Elevator { get; set; }
        public string Comments { get; set; }
    }
    public class TblTaskItems : BaseUser
    {
        public string Name { get; set; }
        public string Makat { get; set; }
        public TypeItem TypeItem { get; set; }

    }
    public class TblTaskConnection : BaseUser
    {
        public TypeConnection TypeConnection { get; set; }
        public string Value { get; set; }
    }
    public class TblWork : BaseUser
    {
        public TblTask TaskID { get; set; }
        public TypeWorkStatus Status { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public TblShift ShiftID { get; set; }
    }

    public class TblShift : BaseUser
    {
        public TblDriver DriverID { get; set; }
        public TblCar CarID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan FromHour { get; set; }
        public TimeSpan ToHour { get; set; }
        public TblEzor EzorID { get; set; }
    }
    public class TblShiftPermanent : BaseUser
    {
        public TblDriver DriverID { get; set; }
        public TblCar CarID { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan FromHour { get; set; }
        public TimeSpan ToHour { get; set; }
        public TblEzor EzorID { get; set; }
    }

    public class TblEzor : BaseUser
    {
        public string Name { get; set; }
    }
    public class TblEzorCity : BaseUser
    {
        public TblEzor EzorID { get; set; }
        public int CityID { get; set; }
    }

    public class TblDriver : BaseUser
    {
        public string Name { get; set; }
        public string Tel { get; set; }
    }

    public class TblCar : BaseUser
    {
        public int CarID { get; set; }
        public TypeCar TypeCar { get; set; }
    }
}
