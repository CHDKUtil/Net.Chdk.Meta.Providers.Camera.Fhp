using Net.Chdk.Meta.Providers.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Fhp
{
    sealed class FhpCameraCardProvider : EosCameraCardProvider
    {
        protected override string GetCardType(uint modelId) => "CF";
    }
}
