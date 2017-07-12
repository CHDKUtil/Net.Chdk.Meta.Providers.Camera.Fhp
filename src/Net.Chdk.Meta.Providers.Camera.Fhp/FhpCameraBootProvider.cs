namespace Net.Chdk.Meta.Providers.Camera.Fhp
{
    sealed class FhpCameraBootProvider : CameraBootProvider
    {
        protected override string GetBootFileSystem(uint modelId) => "FAT32";
    }
}
