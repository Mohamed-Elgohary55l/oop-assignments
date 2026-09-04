using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace oop_assignments
{
    internal struct Shipment
    {
        #region fields
        private string  trackingcode;
        private string description;
        private double weight;
        private decimal deliveryfee;
        #endregion

        #region constructor
        public Shipment(string trackingcode)
        {
            this.trackingcode = trackingcode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string trackingcode, string description, double weight, decimal deliveryfee)
        {
            if (!string.IsNullOrWhiteSpace(description)) 
            { 
            trackingcode = trackingcode; }

            this. trackingcode= trackingcode; 
            Description = description;  
            Weight = weight;
            DeliveryFee = deliveryfee;

        }

        public decimal NewFew(decimal newDeliveryFee)
        {
            if (newDeliveryFee > 0) 
            {
                DeliveryFee = newDeliveryFee;
            }
            return DeliveryFee;
        }
        public void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {trackingcode}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Delivery Fee: ${deliveryfee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        }

        #endregion

        #region properties
        public string TrackingCode
        {
            get { return trackingcode; }
        }
            
           
        public string Description { 
            get { return description; }
            set { 
              if(string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Description cannot be null or empty."); }
                description = value; } }
        public double Weight {
            get { return weight; } 
            set {
                if (value <= 0) { throw new ArgumentException("Weight must be a positive integer."); }

                weight = value; } }
        public decimal DeliveryFee { 
            get { return deliveryfee; }
            private set {
                if (value <= 0) { throw new ArgumentException("Delivery fee must be a positive integer."); }

                deliveryfee = value; } }
        public string Destination
        {
            get; set;
        }
        public decimal EstimatedCost
        {
            get { return deliveryfee + ((decimal)weight * 5m); }
        }
        #endregion


        #region methods

        #endregion
    }
}
