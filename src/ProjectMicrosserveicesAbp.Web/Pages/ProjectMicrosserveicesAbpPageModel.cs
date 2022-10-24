using ProjectMicrosserveicesAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProjectMicrosserveicesAbp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProjectMicrosserveicesAbpPageModel : AbpPageModel
{
    protected ProjectMicrosserveicesAbpPageModel()
    {
        LocalizationResourceType = typeof(ProjectMicrosserveicesAbpResource);
    }
}
