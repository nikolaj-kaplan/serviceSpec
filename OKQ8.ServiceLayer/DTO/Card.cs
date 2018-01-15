using System;

namespace OKQ8.ServiceLayer.DTO
{
    public class Card
    {
        /*TODO danish properties:

        private string stAdr2Field;
        private string stExternNrField;
        private string stForretTypeField;
        private string stGadeField;
        private string stHkontonrField;
        private string stKmstatField;
        private string stKortstatusField;
        private string stNavn1Field;
        private string stNavn2Field;
        private System.DateTime stOpretDatoField;
        private bool stOpretDatoFieldSpecified;
        private string stPostnrField;
        private string stPrLinie2Field;
        private string stPrLinie3Field;
        private string stPrLinie4Field;
        private string stSegTypeField;
        private System.DateTime stSpaerDatoField;
        private bool stSpaerDatoFieldSpecified;
        private string stSprogField;
        private System.DateTime stUdlDatoField;
        private bool stUdlDatoFieldSpecified;
        private string stUkontonrField;
        private string stKortnrField;
        private CardType stKorttypeField;
        private bool stKorttypeFieldSpecified;
*/

        public string CardHolder;
        public string CardNumber;
        public string AccountNumber;

        public DateTime ExpirationDate;

        public CardStatus Status;

        //https://i.imgur.com/o0qIuyO.png
        public CardLimitStatus CardLimitStatus;

        //https://i.imgur.com/lwjW9El.png
        public bool MilageInformationEnabled;

        public PurchaseControlLevel PurchaseControlLevel;

        //TODO: possibly other fields such as address or additional text fields corresponding to text on the card. Let's see what the backen has.
    }

    /// <summary>
    /// TODO: not quite sure about these. Let's see what makes sense from the backende point of view.
    /// </summary>
    public enum CardStatus
    {
         Active,
         Replacement,
         New
    }

    public enum CardLimitStatus
    {
        //https://i.imgur.com/o0qIuyO.png    
    }

    public class PurchaseControlLevel
    {
        //https://gg7ptb.axshare.com/6_1_2_nyt_kort.html
        //https://i.imgur.com/hp7mRbV.png
    }

}