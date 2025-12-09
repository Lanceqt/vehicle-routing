using FastEndpoints;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints();

var app = bld.Build();
app.UseFastEndpoints();
app.Run();


string[] zealandAddresses =
[
    "Københavns Rådhus — Rådhuspladsen 1, 1550 København V",
    "Christiansborg Slot — Prins Jørgens Gård 1, 1218 København K",
    "Nationalmuseet — Ny Vestergade 10, 1471 København K",
    "Roskilde Domkirke — Domkirkepladsen 3, 4000 Roskilde",
    "Kronborg Slot — Kronborg, 3000 Helsingør",
    "Køge Station — Stationspladsen 1, 4600 Køge",
    "Næstved Station — Banegårdspladsen 1, 4700 Næstved",
    "Frederiksborg Slot — Frederiksborg Slot, 3400 Hillerød",
    "Holbæk Station — Banegårdspladsen 1, 4300 Holbæk",
    "Ringsted Station — Stationspladsen 1, 4100 Ringsted"
];
var startingAddress = "Team Lund - Holbækvej 170, 4100 Ringsted";
var numberOfCars = 3;