using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value < 0)
                {
                    this.amount = value;
                }

                else
                {
                    throw new ArgumentException("El descuento no puede ser positivo.");
                }
            }

        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
        }
    }
}