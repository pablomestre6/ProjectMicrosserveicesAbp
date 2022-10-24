using ProjectMicrosserveicesAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProjectMicrosserveicesAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProjectMicrosserveicesAbpController : AbpControllerBase
{
    protected ProjectMicrosserveicesAbpController()
    {
        LocalizationResource = typeof(ProjectMicrosserveicesAbpResource);
    }
}
