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
        [Op]
        public unsafe ReadOnlySpan<ResSeg> ReadResSegments()
        {
            var resources = ReadResDescriptions();
            var count = resources.Length;
            var dst = span<ResSeg>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var res = ref skip(resources, i);
                var resdir = ReadSectionData(ResourcesDirectory);
                var blobReader = resdir.GetReader((int)res.Offset, resdir.Length - (int)res.Offset);
                var length = blobReader.ReadUInt32();
                MemoryAddress address = blobReader.CurrentPointer;
                seek(dst,i) = new ResSeg(res.Name, new MemorySeg(address,length));
            }
            return dst;
        }
    }
}