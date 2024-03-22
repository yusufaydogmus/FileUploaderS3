using Volo.Abp.Modularity;

namespace FileUpload;

[DependsOn(
    typeof(FileUploadDomainModule),
    typeof(FileUploadTestBaseModule)
)]
public class FileUploadDomainTestModule : AbpModule
{

}
