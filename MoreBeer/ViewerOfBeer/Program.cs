using ViewerOfBeer.Components;
using ViewerOfBeer.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.AddServiceDefaults();

// add beer api
builder.Services.AddHttpClient<ApiClient>(options =>
{
  options.BaseAddress = new Uri("https://localhost:7115");
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
