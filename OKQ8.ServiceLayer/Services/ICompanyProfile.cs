using OKQ8.ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OKQ8.ServiceLayer
{
    /// <summary>
    /// https://53c0ru.axshare.com/5_0_virksomhedsprofil__stamdata_.html
    /// https://53c0ru.axshare.com/5_1_aftaler.html
    /// https://53c0ru.axshare.com/5_2_kreditlimit.html
    /// 
    /// </summary>
    public interface ICompanyProfile
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="address"></param>
        /// <param name="invoiceAddress">can be null</param>
        /// <param name="invoiceSendOption"></param>
        /// <param name="contactPerson"></param>
        /// <param name="contactPersonPhoneNumber"></param>
        /// <param name="contactPersonEmail"></param>
        void UpdateCompanyData(
            string companyName, 
            Address address, 
            Address invoiceAddress, 
            InvoiceSendOption invoiceSendOption,
            string contactPerson,
            string contactPersonPhoneNumber,
            string contactPersonEmail
            );

        /// TODO: The wireframes for the tabs "Aftaler" and "Kreditlimit" are not finalized. I will wait with the specification on those services untill
        /// we have some more clarifications in place
    }

    public enum InvoiceSendOption
    {
        ByLetter,
        ByMail,
        ByLetterAndMail
    }
}
