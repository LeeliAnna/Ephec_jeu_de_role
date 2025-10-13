namespace Ephec_jeu_de_role
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero Gandalf = new Hero("Gandalf", 20, "Epée", 5);
            Hero Tartenpion = new Hero("Balrog", 20, "Fouet", 2);
            Hero Frodon = new Hero("Frodon", 100, null);

            Gandalf.Attaquer(Tartenpion);
            Console.WriteLine( Tartenpion.ToString());

            //Gandalf.PropoquerEnDuel(Tartenpion);

            Frodon.Attaquer(Tartenpion);
            Console.WriteLine(Tartenpion.ToString());

        }
    }
}
