// See https://aka.ms/new-console-template for more information
using CsvHelper;
using CsvHelper.Configuration;
using mydatabase;
using System.Formats.Asn1;
using System.Globalization;
using System.Text;

Console.WriteLine("Hello, World!");
string csvPath = @"..\database\uzytkownicy.csv";
var userDataBase = LoadDataBase(csvPath);
Display(userDataBase);
showcollumns(userDataBase);
Console.ReadKey();



static void showcollumns(IEnumerable<Users> usersDatas)
{
    var columns = usersDatas.Where(x => x.nazwisko == "Grabowska");
    Display(columns);

}
static void Display(IEnumerable<Users> usersDatas)
{
    foreach (var usersData in usersDatas)
    {
        Console.WriteLine(usersData);
    }
}

static List<Users> LoadDataBase(string path)
{
    var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";", Encoding = Encoding.UTF8 };
    var reader = new StreamReader(path);
    using (var csv = new CsvReader(reader, config))
    {
        csv.Context.RegisterClassMap<UsersMap>();
        var records = csv.GetRecords<Users>().ToList();
        return records;
    }

}