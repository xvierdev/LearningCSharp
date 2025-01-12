namespace CostManager{
    class Bills{
        public string Name {get; set; }
        public string Description {get; set; }
        public double Value {get; set; }

        public override string ToString()
        {
            return $"{Name} {Value}";
        }
    }
}