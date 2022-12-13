
Console.WriteLine("Du vaknar upp på morgonen, larmet ringer och klockan är 7.00");
beginning:
Console.WriteLine("väljer du att stänga av larmet och gå upp (A), eller att stänga av larmet och somna om (B)?");
string val1 = Console.ReadLine();
if (val1 == "A")
{
    Console.WriteLine("Du går upp och beger dig till skolan i lugn och ro, ");

}

else if (val1 == "B")
{
    Console.WriteLine("ånej nu försov dig. Du skyndar dig till skolan utan att äta frukost, klockan är 9.52. ");
    Console.WriteLine("Du Springer till bussen, men när du kommer fram inser du att bussen är sen. ");
    Console.WriteLine("Nej, nej, nej det var ju prov idag tänker du. Vill du springa till skolan (A), eller ta tunnelbanan (B)?");
    string val2 = Console.ReadLine();

    if (val2 == "A")
    {
        Console.WriteLine("Du tänker lite och bestämmer dig för att springa till skolan även fast det går snabbare att ta tunnelbanan.");
        Console.WriteLine("Efter en lång springtur kommer du till skolan, det är engelska och du är 53 minuter sen. När du öppnar dörren får du en ilsken blick av din lärare, men du går och sätter dig brevid din kompis.");
        Console.WriteLine("Han frågar var du har varit och varför du är så svettig");


    }


    

    

}
else
{
    Console.WriteLine("tyvärr finns inte det alternativet");
    goto beginning;

}


Console.ReadLine();











// Console.WriteLine("Du går på en väg ute på landet, plötsligt delar sig vägen. Man kan gå vänster eller höger. vilken kommer du välja? (skriv vänster eller höger)");
// val1:
// string val1 = Console.ReadLine();


// if (val1 == "höger")
// {
//     Console.WriteLine("du beger dig högerut mot slottet");
//     Console.WriteLine("Du går in i slottet och träffar där en man som erbjuder dig fika och te. Ni har en trevlig stund och du går där ifrån med ett leende på läpparna.");
// }
// else if (val1 == "vänster")
// {
// val2left:
//     Console.WriteLine("du går vänsterut mot sjön");
//     Console.WriteLine("efter ett par timmar har du kommit till den norra änden av sjön.");
//     Console.WriteLine(" du möter en främling som påstår att han nyss såg en jättelik björn nära här och ber om din hjälp att ta sig till säkerhet.");
//     Console.WriteLine("kommer du att hjälpa fränmingen därifrån eller gå ensam?");
//     Console.WriteLine("skriv: tillsammans eller ensam");
//     string val2left = Console.ReadLine();
//     if (val2left == "ensam")
//     {
//         Console.WriteLine("du flyr från skogen ensam. Du klarar dig oskadd. Men när du har lämnat skogen hör du ett skrik från skogen, du ryser till och fortsätter gå");
//     }
//     else if (val2left == "tillsammans")
//     {
//         Console.WriteLine("du försöker ta med dig främlingen ut ur skogen men främlingen blir panikslagen när han får syn på en geting och börjar skrika, björnen hör er och äter upp er båda.");
//     }

//     else
//     {
//         Console.WriteLine("tyvärr finns inte det alternativet");
//         goto val2left;
//     }
// }
// else
// {
//     Console.WriteLine("Tyvärr finns inte det svarsalternativet, försök igen ):");
//     goto val1;
// }
// Console.ReadLine();

