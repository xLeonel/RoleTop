namespace RoleTopMVC.Models
{
    public class Depoimento
    {
        public Cliente Cliente { get; set; }
        public string Mensagem { get; set; }

        public Depoimento()
        {
            this.Cliente = new Cliente();
        }
    }


}