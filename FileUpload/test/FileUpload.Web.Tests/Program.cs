using Microsoft.AspNetCore.Builder;
using FileUpload;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<FileUploadWebTestModule>();

public partial class Program
{
}
