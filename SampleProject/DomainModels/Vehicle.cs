using DomainModels.ValueObject;
using System;
using System.Collections.Generic;

namespace DomainModels.Product.Vehicle
{
    public class Vehicle : IProduct
    {
        public string ProductId
        {
            get
            {
                string id = this.ProductId;
                return id;
            }
            private set
            {
                string id = value;
                this.ProductId = id;
            }
        }

        private bool Active
        {
            get
            {
                return IsActive();
            }
            set
            {
                this.Active = value;
            }
        }
        
        public string VehicleModel
        {
            get
            {
                string vehicleModel = this.VehicleModel;
                return vehicleModel;
            }
            private set
            {
                string vehicleModel = value;
                this.VehicleModel = vehicleModel;
            }
        }

        public DateTime FabricationYear
        {
            get
            {
                return this.FabricationYear;
            }
            set
            {
                this.FabricationYear = value;
            }
        }

        public DateTime ModelYear
        {
            get
            {
                return this.ModelYear;
            }
            set
            {
                this.ModelYear = value;
            }
        }

        public int DoorQuantity
        {
            get
            {
                return this.DoorQuantity;
            }
            set
            {
                this.DoorQuantity = value;
            }
        }

        public int Tire 
        {
            get
            {
                return this.Tire;
            }
            set
            {
                this.Tire = value;
            }
        }

        public string Brand
        {
            get
            {
                string vehicleBrand = this.Brand;
                return vehicleBrand;
            }
            private set
            {
                string vehicleBrand = value;
                this.Brand = vehicleBrand;
            }
        }

        public string BodyWork
        {
            get
            {
                string bodyWork = this.BodyWork;
                return bodyWork;
            }
            private set
            {
                string bodyWork = value;
                this.BodyWork = bodyWork;
            }
        }

        public string TransmissionType
        {
            get
            {
                string transmissionType = this.TransmissionType;
                return transmissionType;
            }
            private set
            {
                string transmissionType = value;
                this.TransmissionType = transmissionType;
            }
        }

        public HashSet<string> Fuel 
        {
            get
            {
                HashSet<string> vehicleFuel = this.Fuel;
                return vehicleFuel;
            }
            private set
            {
                HashSet<string> vehicleFuel = value;
                this.Fuel = vehicleFuel;
            }
        }

        public bool IsActive()
        {
            return this.Active;
        }

        public void ChangeStatusActive(bool status)
        {
            this.Active = status;
        }
    }
}
