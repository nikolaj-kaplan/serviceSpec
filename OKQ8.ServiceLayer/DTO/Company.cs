namespace OKQ8.ServiceLayer.DTO
{
    public class Company
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        /// <summary>
        /// From dk portal
        /// </summary>
        public CompanyType CompanyType { get; set; }

        /// <summary>
        /// From dk portal
        /// </summary>
        public Segment Segment { get; set; }

        /// <summary>
        /// From dk portal
        /// </summary>
        public string District { get; set; }
    }
}