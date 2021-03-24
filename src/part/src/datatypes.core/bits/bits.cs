//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct bits
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bits<T> init<T>(T src = default)
            where T : unmanaged
                => new bits<T>(src);

       [MethodImpl(Inline), Op, Closures(Closure)]
       public static bits<T> init<T>(T src, ushort width)
            where T : unmanaged
                => new bits<T>(src,width);
     }
}