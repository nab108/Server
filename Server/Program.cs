WebApplication app = WebApplication.Create(args);

List<Elev> elevs = [
    new() {Name = "Nabil", Subject = "Prg", Age = 18},
    new() {Name = "Hussein", Subject = "Entr", Age = 18},
    new() {Name = "Hadi", Subject = "GyA", Age = 20},
];



app.MapGet("/", Hello);
app.MapGet("/nabil", Nabil);
app.MapGet("/elev", GimmeElev);
app.MapGet("/elev/{n}", GimmeOneElev); 
app.Run();



List<Elev> GimmeElev()
{
    
    return elevs;
    
}
IResult GimmeOneElev(int n)
{
    if (n < 0 || n >= elevs.Count)
    {
        return Results.NotFound();
    }
    return Results.Ok (elevs[n]); 

}

static string Hello()
{
    return "Hello TE23B";

}
static string Nabil()
{
    return "Världens bästa elev";
}
