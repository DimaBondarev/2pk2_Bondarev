namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://example.com/home/";
            string domainWithTrailingSlash = url.Replace("https://", "").Replace("http://", ""); 
            domainWithTrailingSlash = domainWithTrailingSlash.TrimEnd('/'); 
            string[] domainParts = domainWithTrailingSlash.Split('.');
            string topLevelDomain = domainParts[^1]; 
            Console.WriteLine($"Домен верхнего уровня: {topLevelDomain}");
        }
    }
}
