
Console.WriteLine("USA? Yes or NO :");
string BuyerCountry = Console.ReadLine();

Console.WriteLine("Asaki:");
int BuyerAge = int.Parse(Console.ReadLine());

if (BuyerCountry == "Yes" && BuyerAge <= 20)
{

    Console.WriteLine("No");
}

else if (BuyerCountry == "Yes" && BuyerAge >= 21)

{
    Console.WriteLine("Yes");
}

else if (BuyerCountry == "No" && BuyerAge <= 17)

{
    Console.WriteLine("No");
}

else if (BuyerCountry == "No" && BuyerAge >= 18)

{
    Console.WriteLine("Yes");
}
