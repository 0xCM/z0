//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static System.Runtime.CompilerServices.Unsafe;

    using O = OpacityKind;

    partial struct xsys
    {
        [MethodImpl(Options), Opaque(O.Write), Closures(Closure)]
        public static void write<T>(in T src, ref byte dst)
            => WriteUnaligned(ref dst, src);
    }
}