//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline)]
        public static T[] cast<T>(object[] src)
        {
            var dst = Control.alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = cast<T>(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);
    }
}