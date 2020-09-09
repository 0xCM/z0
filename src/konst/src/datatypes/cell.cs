//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct cell<T>
        where T : struct
    {
        T Value;

        [MethodImpl(Inline)]
        public cell(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public static T operator !(in cell<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator T(in cell<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator cell<T>(in T src)
            => new cell<T>(src);

        [MethodImpl(Inline)]
        public static ref cell<S> morph<S>(in cell<T> src)
            where S : struct
                => ref @as<cell<T>,cell<S>>(src);

        [MethodImpl(Inline)]
        public static ref cell<T> assign(in T src, ref cell<T> dst)
        {
            dst.Value = src;
            return ref dst;
        }
    }
}