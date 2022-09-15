//cibi-preferiti c#

//inizializzare l'array dei cibi preferiti min 5 / max 10
string[] favoriteFoods = { "Pizza", "Pasta", "Gelato", "Sushi", "Kebab","Hamburger", "Fiorentina", "Cioccolato", "Meringa" };

//lunghezza della classifica
Console.WriteLine("la classifica e' lunga : " + favoriteFoods.Length + " elementi");
Console.WriteLine("La classifica consiste in:");
for (int i = 0; i < favoriteFoods.Length; i++) {
    Console.Write( i + 1 +"-");
    Console.WriteLine(favoriteFoods[i]);
}
//cibo preferito
Console.WriteLine("Il mio cibo preferito e': "+ favoriteFoods[0]);
//cibo preferito (ma non troppo) ultima posizione della classifica
Console.WriteLine("Il mio cibo meno e': "+ favoriteFoods[favoriteFoods.Length -1]);
//cibo di meta'
if(favoriteFoods.Length % 2 == 0) {
    Console.WriteLine("Le due mediane sono:" + favoriteFoods[(favoriteFoods.Length-1)/2] + " e "+ favoriteFoods[favoriteFoods.Length / 2]);
}
else {
    Console.WriteLine("La mediana e' :" + favoriteFoods[(favoriteFoods.Length-1)/2]);
}
