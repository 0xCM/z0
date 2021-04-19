//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;

    partial class CliDataReader
    {
        [MethodImpl(Inline), Op]
        public string ReadString(StringHandle src)
            => MetadataReader.GetString(src);

        [MethodImpl(Inline), Op]
        public ref string ReadString(StringHandle src, ref string dst)
        {
            dst = ReadString(src);
            return ref dst;
        }
    }
}