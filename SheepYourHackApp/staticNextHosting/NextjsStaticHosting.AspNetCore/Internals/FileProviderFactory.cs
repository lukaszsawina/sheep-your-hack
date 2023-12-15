using Microsoft.Extensions.FileProviders;

namespace SheepYourHackHosting.Internals
{
    internal class FileProviderFactory
    {
        public virtual IFileProvider CreateFileProvider(string physicalRoot) => new PhysicalFileProvider(physicalRoot);
    }
}
