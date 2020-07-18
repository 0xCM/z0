//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(in S src)
            => ref @as<S,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void cast<T>(ReadOnlySpan<object> src, Span<T> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst, i) = cast<T>(skip(src,i));            
        }
    }
}