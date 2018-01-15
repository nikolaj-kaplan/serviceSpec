namespace OKQ8.ServiceLayer.DTO
{
    public class Company
    {
        public string Name1;
        public string Name2;
        public Address Address;
        public string Phone;

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