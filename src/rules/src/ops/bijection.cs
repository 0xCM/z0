//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bijection<T> bijection<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> dst)
        {
            if(src.Length != dst.Length)
                Errors.ThrowWithOrigin(string.Format("{0} != {1}", src.Length, dst.Length));
            return new Bijection<T>(src, dst);
        }

        [MethodImpl(Inline)]
        public static Bijection<S,T> bijection<S,T>(ReadOnlySpan<S> src, ReadOnlySpan<T> dst)
        {
            if(src.Length != dst.Length)
                Errors.ThrowWithOrigin(string.Format("{0} != {1}", src.Length, dst.Length));
            return new Bijection<S,T>(src, dst);
        }
    }
}