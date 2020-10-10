//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.InteropServices;
    using System.Collections.Immutable;
    using System.IO;
    using System.Runtime;

    using static z;
    using static Konst;


    public static class ManifestResourceLocator
    {
        public static unsafe ManifestResourceDescriptor Descriptor(PEReader pe, MetadataReader reader, string resourceName)
        {

            ManifestResourceDescriptor result = default;
            ManifestResourceHandleCollection manifestResources = reader.ManifestResources;
            foreach (ManifestResourceHandle resourceHandle in manifestResources)
            {
                ManifestResource resource = resourceHandle.GetManifestResource(reader);
                if (resource.Name.Equals(resourceName, reader))
                {
                    if (resource.Implementation.IsNil)
                    {
                        checked
                        {
                            // Embedded data resource
                            result.Location = ResourceLocation.Embedded | ResourceLocation.ContainedInManifestFile;

                            PEMemoryBlock resourceDirectory = pe.GetSectionData(pe.PEHeaders.CorHeader!.ResourcesDirectory.RelativeVirtualAddress);
                            BlobReader blobReader = resourceDirectory.GetReader((int)resource.Offset, resourceDirectory.Length - (int)resource.Offset);
                            uint length = blobReader.ReadUInt32();
                            result.Address = blobReader.CurrentPointer;

                            // Length check the size of the resource to ensure it fits in the PE file section, note, this is only safe as its in a checked region
                            if (length + sizeof(int) > blobReader.Length)
                                throw new BadImageFormatException();
                            result.Size = length;
                        }
                    }
                }
            }

            return result;
        }

    }

    public struct ManifestResourceDescriptor
    {
        public string FileName;

        public MemoryAddress Address;

        public ByteSize Size;

        public ResourceLocation Location;
    }

    public readonly struct RuntimeArchive : IFileArchive<RuntimeArchive>
    {
        public FS.FolderPath Root {get;}

        public Files Libraries {get;}

        public static RuntimeArchive create()
        {
            var root = FS.dir(RuntimeEnvironment.GetRuntimeDirectory());
            return new RuntimeArchive(root,root.Files(FileKind.Dll));
        }

        [MethodImpl(Inline)]
        RuntimeArchive(FS.FolderPath root, Files libs)
        {
            Root = root;
            Libraries = libs;
        }

        public Files ManagedLibraries
        {
            get => Libraries.Where(x => FS.managed(x)).Array();
        }

        public Files NativeLibraries
        {
            get => Libraries.Where(x => !FS.managed(x)).Array();
        }
    }
}