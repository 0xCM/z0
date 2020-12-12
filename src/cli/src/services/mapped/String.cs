//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;

    partial class CliMemoryMap
    {
        [MethodImpl(Inline), Op]
        public string Read(StringHandle src)
            => CliReader.GetString(src);

        [MethodImpl(Inline), Op]
        public ref string Read(StringHandle src, ref string dst)
        {
            dst = Read(src);
            return ref dst;
        }
    }
}