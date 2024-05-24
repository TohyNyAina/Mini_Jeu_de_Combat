using System.Runtime.CompilerServices;

class Guerrier{
    private string nom;
    private int attaque;
    private int deffense;
    private int sante;
    private int mana;

    public Guerrier(string nom, int attaque, int deffense, int sante){
        this.nom = nom;
        this.attaque = attaque;
        this.deffense = deffense;
        this.sante = sante;
        this.mana = 100;
    }
    public void LancerAttaqueSur(Guerrier cible){
        cible.sante -= this.attaque;
    }
    public void LancerAttaqueAvecDefenseSur(Guerrier cible) {
        if (this.attaque > cible.deffense)
        {
            cible.sante -= this.attaque;
        }
        else if (this.attaque < cible.deffense) { 
            this.sante -= (cible.deffense - this.attaque);
        }
    }

    public void ActiverSoin()
    {
        if (this.mana >= 10){
            this.sante += 20;
            this.mana -= 10;
        }
        else {
            Console.WriteLine("Le Guerier " + this.nom + " n'a pas assez de mana pour lancer un soin.");
        }
    }
    public void AfficherInformations(){
        Console.WriteLine("Nom : " +  this.nom);
        Console.WriteLine("attaque : " + this.attaque);
        Console.WriteLine("deffense : " + this.deffense);
        Console.WriteLine("sante : " + this.sante);
    }

    public string Nom
    {
        get { return this.nom; }
        set { this.nom = value; }
    }
    public int Attaque
    {
        get { return this.attaque; }
        set { this.attaque = value; }
    }
    public int Deffense
    {
        get { return this.deffense; }
        set { this.deffense = value; }    
    }
    public int Sante 
    { 
        get { return this.sante; }
        set { this.sante = value; }
    }
    public int Mana
    {
        get { return this.mana; }
        set { this.mana = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrier guerrier1 = new Guerrier("Madara", 20, 10, 50);
        Guerrier guerrier2 = new Guerrier("Hashirama", 25, 30, 10);

        Console.WriteLine("Guerrier 1: ");
        guerrier1.AfficherInformations();

        Console.WriteLine("\nGuerrier 2 : ");
        guerrier2.AfficherInformations();

        //Guerrier 1 attaque Guerrier 2
        guerrier1.LancerAttaqueSur(guerrier2);
        Console.WriteLine("\nApres l'attaque de Guerrier 1 : ");
        guerrier1.AfficherInformations();
        guerrier2.AfficherInformations();

        //Guerrier 2 attaque guerrier 1avec défense
        guerrier2.LancerAttaqueAvecDefenseSur(guerrier1);
        Console.WriteLine("\nAprés l'attaque de Guerrier 2 avec défense : ");
        guerrier1.AfficherInformations();
        guerrier2.AfficherInformations();

        //Guerrier 1 active un soin
        guerrier1.ActiverSoin();
        Console.WriteLine("\nAprès le soin de Guerrier 1 :");
        guerrier1.AfficherInformations();
    }
}