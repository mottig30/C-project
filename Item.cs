using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JavierS
{
    class Item
    {
        private int itemId;
        private Model model;
        private EnumSize EnumSize;
        private EnumColor EnumColor;
        public System.Collections.Generic.List<ItemInOrder> itemsInOrderList;


        public Item(int itemId,Model model, EnumSize EnumSize, EnumColor EnumColor) //constructor
        {
            this.itemId=itemId;
            this.EnumSize = EnumSize;
            
            this.EnumColor = EnumColor;
            this.model = model;
            this.itemsInOrderList = new System.Collections.Generic.List<ItemInOrder>();
        }

        public void updateItemStatus()
        {
        }

        public int getItemId() {
            return this.itemId;
        }

        public string getItemSize()
        {
            return this.EnumSize.ToString();
        }

        public string getItemColore()
        {
            return this.EnumColor.ToString();
        }

        public Model getModel()
        {
            return this.model;
        }


    }
}
