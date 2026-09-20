using ClienteBlazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient 

{
    BaseAddress = new Uri("https://api-estudiantes-leanny-2026-dkc2cehwephjh7hc.centralus-01.azurewebsites.net/")

});

await builder.Build().RunAsync();
