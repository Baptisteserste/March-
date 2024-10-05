// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
Console.Write("Entrez votre nom : ");
var nom = Console.ReadLine();
Console.Write("Entrez votre âge : ");
var age = Console.ReadLine();
// Affichage des données saisies
Console.WriteLine("Bonjour, " + nom + "! Vous avez " + age + " ans.");
Console.WriteLine($"Bonjour, je m'appelle {nom} et j'ai {age} ans.");
// Attendre que l'utilisateur appuie sur une touche pour fermer la console
Console.ReadKey();
// demander a l'utilisateur d'encoder  nombre(int), si le modulo de 2 est 0, afficher "le nombres est paire"
// sinon "le nombre est impaire" et gérer les erreurs.
Console.Write("Entrer un nombre : ");
Console.WriteLine(
    int.TryParse(Console.ReadLine(), out int nombre)      
    ? nombre % 2 == 0
            
         ? " le nombre est paire"
         : "Le nombre est impair."
    : "Veuillez entrer un nombre entier valide.");
Console.ReadKey();

// /*Développez une calculatrice simple. L'utilisateur devrait pouvoir entrer entrer deux nombres et un opérateur (+,-,*,/)
// pour effectuer une opération arithmétique. Le programme devrait utiliser l'instruction "switch" pour déterminer 
// quelle opération effectuer en fonction de l'opérateur saisi et afficher le résultat.
Console.WriteLine("Calculatrice simple");
        
        // Saisie du premier nombre
        Console.Write("Entrez le premier nombre : ");
        if (!double.TryParse(Console.ReadLine(), out double nombre1))
        {
            Console.WriteLine("Entrée invalide pour le premier nombre.");
            return; // Sortie si l'entrée est invalide
        }

        // Saisie du deuxième nombre
        Console.Write("Entrez le deuxième nombre : ");
        if (!double.TryParse(Console.ReadLine(), out double nombre2))
        {
            Console.WriteLine("Entrée invalide pour le deuxième nombre.");
            return; // Sortie si l'entrée est invalide
        }

        // Saisie de l'opérateur
        Console.Write("Entrez un opérateur (+, -, *, /) : ");
        string operateur = Console.ReadLine();
        double result; // Variable pour stocker le résultat

        // Détermination de l'opération à effectuer
        switch (operateur)
        {
            case "+":
                result = nombre1 + nombre2;
                Console.WriteLine($"Le résultat de {nombre1} + {nombre2} est : {result}");
                break;
            case "-":
                result = nombre1 - nombre2;
                Console.WriteLine($"Le résultat de {nombre1} - {nombre2} est : {result}");
                break;
            case "*":
                result = nombre1 * nombre2;
                Console.WriteLine($"Le résultat de {nombre1} * {nombre2} est : {result}");
                break;
            case "/":
                if (nombre2 != 0) // Vérifie si le dénominateur est zéro
                {
                    result = nombre1 / nombre2;
                    Console.WriteLine($"Le résultat de {nombre1} / {nombre2} est : {result}");
                }
                else
                {
                    Console.WriteLine("Erreur : Division par zéro."); // Gère la division par zéro
                }
                break;
            default:
                Console.WriteLine("Opérateur invalide. Veuillez utiliser +, -, * ou /."); // Gère les opérateurs invalides
                break;
        }
        
        // Attendre que l'utilisateur appuie sur une touche avant de fermer
        Console.ReadKey();

//Vérifier qu'un compte bancaire BBAN est valide et afficher le résultat dans la console. (Il est valide si le modulo des 10 premiers chiffres par 97 donne les 2 derniers ou ils valent 97 s'il vaut 0).
//Exemple valide : 539007547034
Console.WriteLine("Entrez BBAN");

var bban = Console.ReadLine();

Console.WriteLine(
    bban?.Length == 12
    && long.TryParse(bban[..10],out var num)
    &&((num % 97).ToString("00") == bban[10..]
   || (num % 97 == 0 && bban[10..] == "97"))
   ? "Valide"
   : "Invalide" );
Console.ReadKey();

// Calculer la somme de tous les nombres pairs de 1 à 100 à l'aide d'une boucle "for".
int somme = 0;
for (int i = 0; i <= 100; i++)
   if (i % 2 == 0)
            {
                somme += i; // Ajouter le nombre pair à la somme
            }
Console.WriteLine(somme);
Console.ReadKey();
// Calculer la factoriel d'un nombre entré au clavier à l'aide d'une boucle "while".
Console.WriteLine("Entrez un nombre : ");
 if (int.TryParse(Console.ReadLine(), out int fractionel) && fractionel >= 0) 

 { int resultat = 1;
            while (fractionel > 1)
            {
                resultat *= fractionel;  
                fractionel--;            
            }

            // Afficher le résultat final
            Console.WriteLine(resultat);
        }
Console.ReadKey();
// Calculer de la somme et de la moyenne des éléments d'un tableau
 int[] tableau = { 10, 20, 30, 40, 50 };

    int sommetab = 0;

    foreach (var item in tableau)
            sommetab += item; 

double moyenne = ( double)somme/ tableau.Length;

Console.WriteLine("Le tableau est : " + string.Join(", ", tableau));
Console.WriteLine($"La somme des éléments du tableau est : {somme}");
Console.WriteLine($"La moyenne des éléments du tableau est : {moyenne}");

Console.ReadKey();
// Trouver les éléments maximum et minimum dans un tableau
    int maximum = tableau[0];
    int minimum = tableau[0];

    foreach (var item in tableau)
    {
            if (item > maximum)
            {
                maximum = item; 
            }
            if (item < minimum)
            {
                minimum = item;  
    }
}
Console.WriteLine($"L'élément maximum du tableau est : {maximum}");
Console.WriteLine($"L'élément minimum du tableau est : {minimum}");

//remplir et afficher une matrice de 10x10 avec les nombres de 1 à 100

// Ecrivez une fonction nommée "AdditionnerNombresPairs" qui prend un entier 
// positif comme argument et calcule la somme de tous les nombres pairs de 1 à cet entier.
static int AdditionnerNombresPairs(int nbre)
    {
        int somme = 0;
        for (int i = 2; i <= nbre; i += 2) 
        {
            somme += i;
        }
    return somme;
    }
Console.WriteLine(somme);