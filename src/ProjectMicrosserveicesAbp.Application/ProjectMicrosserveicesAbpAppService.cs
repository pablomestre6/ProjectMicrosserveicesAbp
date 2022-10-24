using System;
using System.Collections.Generic;
using System.Text;
using ProjectMicrosserveicesAbp.Localization;
using Volo.Abp.Application.Services;

namespace ProjectMicrosserveicesAbp;

/* Inherit your application services from this class.
 */
public abstract class ProjectMicrosserveicesAbpAppService : ApplicationService
{
    protected ProjectMicrosserveicesAbpAppService()
    {
        LocalizationResource = typeof(ProjectMicrosserveicesAbpResource);
    }
}
