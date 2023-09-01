namespace Domain
{
    public class Actor
    {
        private string _name;

        public string Name { 
            get 
            {
                return _name;
            }
            set 
            {
                if(value == "")
                {
                    throw new ArgumentException("El nombre no puede ser vacio");
                }
                _name = value;
            } 
        }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}