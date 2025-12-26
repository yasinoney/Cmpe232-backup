using Cmpe232Web.Client.Pages;
using Cmpe232Web.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cmpe232Web.Data;

var builder = WebApplication.CreateBuilder(args);

// DbContext Fabrikasý ayarlarý
builder.Services.AddDbContextFactory<Cmpe232WebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cmpe232WebContext") ?? throw new InvalidOperationException("Connection string 'Cmpe232WebContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// --- KRÝTÝK DEÐÝÞÝKLÝK BURADA ---
// Hem Server hem WebAssembly bileþenlerini ekliyoruz (IMG_9378 hatasýný çözer)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()    // Bu satýrý ekledik
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// HTTP istek hattý yapýlandýrmasý
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// --- KRÝTÝK DEÐÝÞÝKLÝK BURADA ---
// Sunucuya hangi render modlarýný desteklediðimizi söylüyoruz
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()      // Bu satýrý ekledik (Butonlarýn çalýþmasýný saðlar)
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Cmpe232Web.Client._Imports).Assembly);

app.Run();