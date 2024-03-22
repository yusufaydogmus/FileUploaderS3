using Volo.Abp.Modularity;

namespace FileUpload;

/* Inherit from this class for your domain layer tests. */
public abstract class FileUploadDomainTestBase<TStartupModule> : FileUploadTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
