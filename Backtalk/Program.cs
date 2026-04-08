using Backtalk;
using Backtalk.Classes.Data;
using Backtalk.Services;
using Blazored.LocalStorage;
using KristofferStrube.Blazor.FileSystemAccess;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddFileSystemAccessService();
builder.Services.AddSingleton<AppDb>();
builder.Services.AddScoped<INotificationService, NotificationService>();

await builder.Build().RunAsync();
