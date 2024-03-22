using Volo.Abp.Modularity;

namespace FileUpload;

public abstract class FileUploadApplicationTestBase<TStartupModule> : FileUploadTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
