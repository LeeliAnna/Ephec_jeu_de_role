namespace Ephec_jeu_de_role
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero Gandalf = new Hero("Gandalf", 20);
            Hero Tartenpion = new Hero("Balrog", 20);

            Gandalf.Attaquer(Tartenpion);
            Console.WriteLine( Tartenpion.ToString());

            Gandalf.PropoquerEnDuel(Tartenpion);

        }
    }
}
