using Net.Chdk.Meta.Providers.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Fhp
{
    sealed class FhpCardProvider : EosCardProvider
    {
        protected override string GetCardType(uint modelId) => "CF";
    }
}
