//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static memory;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public ref ManifestResource ReadResource(ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = ReadResource(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public ManifestResource ReadResource(ManifestResourceHandle src)
            => CliReader.Read(src);

        [Op]
        public unsafe bool ResourceSearch(string name, out ResSeg dst)
        {
            dst = default;

            var directory = ReadSectionData(ResourcesDirectory);
            var descriptions = ReadResDescriptions();
            var count = descriptions.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var description = ref skip(descriptions, i);
                if(description.Name.Equals(name))
                {
                    var blobReader = directory.GetReader((int)description.Offset, directory.Length - (int)description.Offset);
                    var length = blobReader.ReadUInt32();
                    MemoryAddress address = blobReader.CurrentPointer;
                    dst = new ResSeg(name, new MemorySeg(address,length));
                    return true;
                }
            }
            return false;
        }

    }
}