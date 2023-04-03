namespace webApp1.Models
{
    public class Cliente
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int years { get; set; }

        public Cliente(string id, string name, string email, int years)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.years = years;

        }
    }


 

}
