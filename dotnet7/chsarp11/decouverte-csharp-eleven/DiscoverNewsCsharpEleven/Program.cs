int safetyScore = 18;

string message = $"The usage policy for {safetyScore} is {safetyScore switch
{
    > 90 => "Unlimited usage",
    > 80 => "General usage, with daily safety check",
    > 70 => "Issues must be addressed within 1 week",
    > 50 => "Issues must be addressed within 1 day",
    _ => "Issues must be addressed before continued use",
}}";


string testLong = $"""
    ce text est 
    très long {safetyScore}
""";