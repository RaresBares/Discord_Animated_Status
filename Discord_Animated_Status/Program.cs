using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace Discord_Animated_Status
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            String auth = "****************";
            bool f = false;
            String[] states = new[] {"R", "Ra", "Rar", "Rare", "Rares","Rares", " + ", "N", "No", "Noa", "Noah", "Noah", " = ", " ♥️️ ", "Nohomo","NoNoah", "Nohomo","NoNoah", "Nohomo","NoNoah", "Nohomo"};
            while (true)
            {
                foreach (var state in states)
                {
                    updateStatus(state,auth);
             //       rename(state, auth, "****************");
                    Thread.Sleep(50);
                }
            }
         

        }

        public static void updateStatus(String Status, String auth)
        {
                  
            var handler = new HttpClientHandler();

// If you are using .NET Core 3.0+ you can replace `~DecompressionMethods.None` to `DecompressionMethods.All`
handler.AutomaticDecompression = ~DecompressionMethods.None; 

using (var httpClient = new HttpClient(handler))
{
using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), "https://discordapp.com/api/v8/users/@me/settings"))
    {
        request.Headers.TryAddWithoutValidation("authority", "discordapp.com");
        request.Headers.TryAddWithoutValidation("x-super-properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjAuMC4zMDciLCJvc192ZXJzaW9uIjoiMTAuMC4xODM2MiIsIm9zX2FyY2giOiJ4NjQiLCJjbGllbnRfYnVpbGRfbnVtYmVyIjo2NjA4NiwiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=");
        request.Headers.TryAddWithoutValidation("origin", "https://discordapp.com");
        request.Headers.TryAddWithoutValidation("authorization", auth);
        request.Headers.TryAddWithoutValidation("accept-language", "de");
        request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.307 Chrome/78.0.3904.130 Electron/7.3.2 Safari/537.36");
        request.Headers.TryAddWithoutValidation("accept", "*/*");
        request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-origin");
        request.Headers.TryAddWithoutValidation("sec-fetch-mode", "cors");
        request.Headers.TryAddWithoutValidation("referer", "https://discordapp.com/channels/621052531807879191/632497830916784129");
        request.Headers.TryAddWithoutValidation("accept-encoding", "gzip, deflate, br");
        request.Headers.TryAddWithoutValidation("cookie", "__cfduid=dcd312416555f06e8f980c5e8810fbc3b1597776530; locale=de; __cfruid=bc7b33e1b655381ac74d78cb7c65329e758d6c7b-1598804752"); 

        request.Content = new StringContent("{\"custom_status\":{\"text\":\"" + Status + "\",\"expires_at\":\"2020-08-30T22:00:00.000Z\"}}");
        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json"); 

        var response =  httpClient.SendAsync(request);
        Console.WriteLine(response.Result.StatusCode);
    }
}
            
        }


      
             public static void rename(String nick, String auth, String Guild){
    
    var handler = new HttpClientHandler();

// If you are using .NET Core 3.0+ you can replace `~DecompressionMethods.None` to `DecompressionMethods.All`
handler.AutomaticDecompression = ~DecompressionMethods.None; 

using (var httpClient = new HttpClient(handler))
{
    using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), "https://discordapp.com/api/v8/guilds/" + Guild + "/members/%40me/nick"))
    {
        request.Headers.TryAddWithoutValidation("authority", "discordapp.com");
        request.Headers.TryAddWithoutValidation("x-super-properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjAuMC4zMDciLCJvc192ZXJzaW9uIjoiMTAuMC4xODM2MiIsIm9zX2FyY2giOiJ4NjQiLCJjbGllbnRfYnVpbGRfbnVtYmVyIjo2NjA4NiwiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=");
        request.Headers.TryAddWithoutValidation("origin", "https://discordapp.com");
        request.Headers.TryAddWithoutValidation("authorization", auth);
        request.Headers.TryAddWithoutValidation("accept-language", "de");
        request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.307 Chrome/78.0.3904.130 Electron/7.3.2 Safari/537.36");
        request.Headers.TryAddWithoutValidation("accept", "*/*");
        request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-origin");
        request.Headers.TryAddWithoutValidation("sec-fetch-mode", "cors");
        request.Headers.TryAddWithoutValidation("referer", "https://discordapp.com/channels/621052531807879191/659431564509446155");
        request.Headers.TryAddWithoutValidation("accept-encoding", "gzip, deflate, br");
        request.Headers.TryAddWithoutValidation("cookie", "__cfduid=dcd312416555f06e8f980c5e8810fbc3b1597776530; locale=de; __cfruid=bc7b33e1b655381ac74d78cb7c65329e758d6c7b-1598804752"); 

        request.Content = new StringContent("{\"nick\":\"" + nick+ "\"}");
        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json"); 

        var response =  httpClient.SendAsync(request);
    }
}
    
    }
            
        }
        

    }
    
    
   

