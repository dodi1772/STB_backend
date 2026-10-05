using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
// A kötelező szolgáltatások hozzáadása a konténerhez.
builder.Services.AddControllers();
var supabaseUrl = builder.Configuration["SUPABASE:URL"];
var supabaseKey = builder.Configuration["SUPABASE:KEY"];

var option = new Supabase.SupabaseOptions { AutoConnectRealtime = true };

var supabaseClient = new Supabase.Client(supabaseUrl, supabaseKey, option);
supabaseClient.Postgrest.Options.SerializeEnumsAsStrings = true;
builder.Services.AddSingleton(supabaseClient);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
var app = builder.Build();
// A HTTP-kérelmek feldolgozása.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();