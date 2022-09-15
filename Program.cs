//cibi-preferiti c#

//inizializzare l'array dei cibi preferiti min 5 / max 10
string[] favoriteFoods = { "Pizza", "Pasta", "Gelato", "Sushi", "Kebab","Hamburger", "Fiorentina", "Cioccolato" };

//lunghezza della classifica
Console.WriteLine("la classifica e' lunga : " + favoriteFoods.Length + " elementi");
Console.WriteLine("La classifica consiste in:");
for (int i = 0; i < favoriteFoods.Length; i++) {
    Console.WriteLine(favoriteFoods[i]);
}
//cibo preferito
Console.WriteLine("Il mio cibo preferito e': "+ favoriteFoods[0]);
//cibo preferito (ma non troppo) ultima posizione della classifica
Console.WriteLine("Il mio cibo preferito e': "+ favoriteFoods[favoriteFoods.Length -1]);