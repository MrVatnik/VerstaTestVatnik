namespace VerstaTestVatnik.Models
{
    public class Order
    {
        int Id { get; set; }
        string SenderCity { get; set; }
        string SenderAddress { get; set; }
        string RecepientCity { get; set; }
        string RecepientAddress { get; set; }
        float Weight { get; set; }
        DateOnly Date { get; set; }

        Order(string senderCity, string senderAddress, string recepientCity, string recepientAddress, float weight, DateOnly date)
        {
            SenderCity = senderCity;
            SenderAddress = senderAddress;
            RecepientCity = recepientCity;
            RecepientAddress = recepientAddress;
            Weight = weight;
            Date = date;
        }
    }
}
