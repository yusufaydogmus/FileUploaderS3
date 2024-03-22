using FileUpload.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FileUpload.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FileUploadEntityFrameworkCoreModule),
    typeof(FileUploadApplicationContractsModule)
    )]
public class FileUploadDbMigratorModule : AbpModule
{
}
