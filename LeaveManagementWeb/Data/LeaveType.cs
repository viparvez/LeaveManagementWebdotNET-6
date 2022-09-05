namespace LeaveManagementWeb.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        //DefaultDays; Maximum allowed leaves per type, e.g., Sick Leave - (15 days), Annual Leave (20 days)
        public int DefaultDays { get; set; }
    }
}
