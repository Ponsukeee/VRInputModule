using System.Threading.Tasks;
using VRUtils.Components;

namespace VRUtils.InputModule
{
public interface IInputModule
{
    IInputModule HandleInput(InputType input, DeviceInfo deviceInfo);
    void OnSet();
    void OnUnset();
}
}