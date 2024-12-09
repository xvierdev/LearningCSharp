namespace GenericClass{
    class Generic(string name)
    {
        private string _name = name;
        private int _id;

        public Generic(int id, string name) : this(name){
            this._id = id;
        }

        public void SetName (string name){
            this._name = name;
        }

        public string GetName(){
            return _name;
        }

        public void SetId (int id){
            this._id = id;
        }

        public int GetId(){
            return this._id;
        }
    }
}