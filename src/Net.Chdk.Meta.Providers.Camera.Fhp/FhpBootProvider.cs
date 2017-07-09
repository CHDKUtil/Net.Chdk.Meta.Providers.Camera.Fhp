namespace Net.Chdk.Meta.Providers.Camera.Fhp
{
    sealed class FhpBootProvider : BootProvider
    {
        protected override string GetBootFileSystem(uint modelId) => "FAT32";
    }
}
