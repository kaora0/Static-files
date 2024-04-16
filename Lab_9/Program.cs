var builder = WebApplication.CreateBuilder(
    new WebApplicationOptions { WebRootPath = "staticFile" });  // �������� ����� ��� �������� �������
var app = builder.Build();

//app.UseDefaultFiles();

DefaultFilesOptions options = new DefaultFilesOptions();
options.DefaultFileNames.Clear(); // ������� ����� ������ �� ���������
options.DefaultFileNames.Add("my.html"); // ��������� ����� ��� �����
app.UseDefaultFiles(options); // ��������� ����������

app.UseStaticFiles();   // ��������� ��������� ����������� ������

app.Run(async (context) => await context.Response.WriteAsync("Hello World"));

app.Run();
