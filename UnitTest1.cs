using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace action_hello_world
{
    public class UnitTest1
    {
        [Fact]
        public async Task HttpClientTest()
        {
            using (var client = new HttpClient())
            {
                await client.GetAsync("http://www.google.com").ConfigureAwait(false);
            }
        }
    }
}
