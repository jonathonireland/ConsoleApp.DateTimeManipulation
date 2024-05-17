// Date and Time
Console.WriteLine("************ - DateTime Manipulation - *************");

// Empty DateTime object
DateTime dateTime = new DateTime();

// Create a DateTime from date and time
var dateOfBirth = new DateTime(1980, 12, 25);
Console.WriteLine($"My Dob is: {dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1980, 12, 25, 14, 45, 25, DateTimeKind.Local);
Console.WriteLine($"My Dob is: {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

// Create Date Time from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now is: "+ now);

// Create a DateTime from a String
Console.WriteLine("What is your DOB (dd/mm/yyyy): ");
string dob = Console.ReadLine();

var userDob = DateTime.Parse(dob);
Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
Console.WriteLine($"Tick: {userDob.Ticks}");
Console.WriteLine($"Kind: {userDob.Kind}");

// Change the format of a date time:
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM dd, yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob:dddd-MMMM-yyyy}"); // interpolation only

// Add Additional Time
Console.WriteLine($"One Hour from now is: {now.AddHours(1)}");
Console.WriteLine($"One Day from now is: {now.AddDays(1)}");
Console.WriteLine($"One day ago from now is {now.AddDays(-1)}");

Console.WriteLine("************ - DateTime Offset Manipulation - *************");

// UTC
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Date Time: {now}");
Console.WriteLine($"UTC Now Date Time: {utcNow}");

var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"User Time Zone: {tz}");

var dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

Console.WriteLine("************ - Date Only and Time only manipulation - *************");

