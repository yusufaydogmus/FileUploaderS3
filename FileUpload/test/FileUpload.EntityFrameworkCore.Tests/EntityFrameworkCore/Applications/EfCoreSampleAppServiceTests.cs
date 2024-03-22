using FileUpload.Samples;
using Xunit;

namespace FileUpload.EntityFrameworkCore.Applications;

//[Collection(FileUploadTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FileUploadEntityFrameworkCoreTestModule>
{

}
