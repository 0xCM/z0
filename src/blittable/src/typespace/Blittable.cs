//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.core;
    using static Z0.Root;

    [ApiHost("types.blittable")]
    public readonly partial struct Blittable
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static name name(string src)
            => new name(src);
    }
}