using IM.Domain.Model;

namespace IM.Domain.Interface.Service
{
    public interface IIntegrationsProcessService
    {
        void UpdateProcess();
        Process GetLastProcess();
    }
}
