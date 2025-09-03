namespace Training_FrontEnd.Models
{
    public class ApiResponse<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
    }



    public class School
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime Date { get; set; }
        public string location { get; set; }
        public string city { get; set; }

    }
}
