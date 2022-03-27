namespace OOP_Workshop
{
   public class VariablePriceProduct : Product
   {
      public string Measurement { get; set; }
      public float Quantity { get; set; }

      public override decimal ValueToPay()
      {
         return ((decimal)Quantity * Price) * ((decimal)Tax + 1);
      }

      public override string ToString()
      {
         return $"  {Id} {Description}" +
            $"\n\tMeasurement.............: {Measurement,20}" +
            $"\n\tQuantity................: {Quantity,20:N2}" +
            $"\n\tPrice...................: {Price,20:C2}" +
            $"\n\tTax.....................: {Tax,20:P2}" +
            $"\n\tValue...................: {ValueToPay(),20:C2}";
      }
   }
}
