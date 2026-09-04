using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace oop_assignments
{
    public struct DeliveryCenter
    {
        #region fields
        private Shipment[] shipments = new Shipment[10];
        #endregion


        #region constractors
        public DeliveryCenter()
        {
        }
        #endregion
        #region indexers
        public Shipment this[int postion, Shipment s]
        {

            get
            {

                if (postion < 0 || postion >= shipments.Length)
                    return default;

                return shipments[postion];
            }
            set
            {
                if (postion < 0 || postion >= shipments.Length)
                    return;

                shipments[postion] = value;
            }

        }

        public Shipment this[string trackingcode]
        {

            get
            {
                if (string.IsNullOrWhiteSpace(trackingcode))
                    return default;

                foreach (var shipment in shipments)
                {
                    if (shipment.TrackingCode == trackingcode)
                        return shipment;
                }

                return default;





            }


            }



        #endregion


            #region methods

                public bool AddShipment(Shipment shipment)
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i].TrackingCode == null)
                        {
                            shipments[i] = shipment;
                            return true;
                        }
                    }
                    return false;
                }



            #endregion



        }
    }

