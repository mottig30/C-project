using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierS
{
    class Model
    {
        private int modelID;
        private float price;
        private EnumModelType modelType;
        private Supplier Supplier;
        public System.Collections.Generic.List<Item> itemsList;
        public Model(int modelID, EnumModelType modelType, float price, Supplier Supplier)//add enum
        {
            this.modelID = modelID;
            this.modelType = modelType;
            this.price = price;
            this.Supplier = Supplier;
            this.itemsList = new System.Collections.Generic.List<Item>();
        }

        private void updateModel()
        {

        }

        public float getPrice()
        {
            return this.price;
        }

        public int getID()
        {
            return this.modelID;
        }

        public Supplier getSupplier()
        {
            return this.Supplier;
        }
    }
}
