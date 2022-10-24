using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProjectMicrosserveicesAbp.Web;

[Dependency(ReplaceServices = true)]
public class ProjectMicrosserveicesAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProjectMicrosserveicesAbp";
}
