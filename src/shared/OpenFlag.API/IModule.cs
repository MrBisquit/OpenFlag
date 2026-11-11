using Microsoft.Extensions.DependencyInjection;

namespace OpenFlag.Core
{
    /// <summary>
    /// This is the interface that all of the OpenFlag modules are based on.
    /// </summary>
    public interface IModule : IDisposable
    {
        public void Init(IServiceCollection services);
    }
}
