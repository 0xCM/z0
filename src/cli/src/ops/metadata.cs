//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Konst;

    partial struct Cli
    {
        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref Ref metadata(Assembly src, out Ref dst)
        {
            src.TryGetRawMetadata(out var ptr, out var len);
            dst = new Ref(ptr,(ulong)len);
            return ref dst;
        }
    }
}