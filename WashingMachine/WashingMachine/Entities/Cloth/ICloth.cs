using WashingMachine.Enums;

namespace WashingMachine.Entities.Cloth
{
    public interface ICloth
    {
        CleanType currentState { get; }
    }
}
