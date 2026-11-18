using Microsoft.Extensions.DependencyInjection;

namespace OpenFlag.Core
{
    /// <summary>
    /// This is the interface that all of the OpenFlag modules are based on.
    /// </summary>
    public interface IModule : IDisposable
    {
        /// <summary>
        /// Initialises the module, registering all the services.
        /// </summary>
        /// <param name="services">The IServiceCollection from the runner.</param>
        public void Init(IServiceCollection services);
    }
}
