using DevelopmentPlusAsessement;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
var list2 = new List<int> { 5, 15, 3, 19, 35, 50, -1, 0 }; ;

app.MapGet("/", () => DuplicateChecker<int>.CheckDuplicates(list1, list2));

//app.MapGet("/", () => CheckFiles.FindText("Test", "values"));

app.Run();
