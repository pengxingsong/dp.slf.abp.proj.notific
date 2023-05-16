using System.Threading.Tasks;
using DPNotific.Configuration.Dto;

namespace DPNotific.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
