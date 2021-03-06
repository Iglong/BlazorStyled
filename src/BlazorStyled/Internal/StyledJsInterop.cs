using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorStyled.Internal
{
    class StyledJsInterop
    {
        private readonly IJSRuntime _jsRuntime;
        private IConfig _config;

        public StyledJsInterop(IJSRuntime jsRuntime, IConfig config)
        {
            _jsRuntime = jsRuntime;
            _config = config;
        }

        public Task<int> InsertRule(string rule)
        {
            return _jsRuntime.InvokeAsync<int>("styledJsFunctions.insertRule", rule, _config.IsDevelopment);
        }
    }
}