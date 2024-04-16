var builder = WebApplication.CreateBuilder(
    new WebApplicationOptions { WebRootPath = "staticFile" });  // изменяем папку для хранения статики
var app = builder.Build();

//app.UseDefaultFiles();

DefaultFilesOptions options = new DefaultFilesOptions();
options.DefaultFileNames.Clear(); // удаляем имена файлов по умолчанию
options.DefaultFileNames.Add("my.html"); // добавляем новое имя файла
app.UseDefaultFiles(options); // установка параметров

app.UseStaticFiles();   // добавляем поддержку статических файлов

app.Run(async (context) => await context.Response.WriteAsync("Hello World"));

app.Run();
