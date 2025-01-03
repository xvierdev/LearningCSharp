namespace GenericClass
{
    class Product
    {
        private string _name;
        private int _id;

        public Product(){
            
        }

        public Product(int id){
            _id = id;
        }

        public Product(int id, string name) : this(id)
        {
            _name = name;
        }

        public string Name
        {
            get { return this._name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}