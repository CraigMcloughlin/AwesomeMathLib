
var person = new Person { FirstName = "Albert", LastName = "Einstein ", YearOfBirth = 1879 };
string json = Newtonsoft.Json.JsonConvert.SerializeObject(person);
Console.WriteLine(json);

public class Person {
   public string FirstName { get; init; }
   public string LastName { get; init; }
   public int YearOfBirth { get; init; }
}