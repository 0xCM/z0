//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct ImageMetadata
    {
        [Op]
        public static bool valid(FS.FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);
            return reader.HasMetadata;
        }

        [Op]
        public static PeReader reader(FS.FilePath src)
            => new PeReader(src);

        [Op]
        public static bool reader(FS.FilePath src, out PeReader dst)
        {
            if(valid(src))
            {
                dst = new PeReader(src);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }
    }
}