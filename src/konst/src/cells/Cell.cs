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

    public struct Cell<T>
        where T : struct
    {
        T Value;

        [MethodImpl(Inline)]
        public Cell(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public static T operator !(in Cell<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator T(in Cell<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Cell<T>(in T src)
            => new Cell<T>(src);

        [MethodImpl(Inline)]
        public static ref Cell<S> morph<S>(in Cell<T> src)
            where S : struct
                => ref @as<Cell<T>,Cell<S>>(src);

        [MethodImpl(Inline)]
        public static ref Cell<T> assign(in T src, ref Cell<T> dst)
        {
            dst.Value = src;
            return ref dst;
        }
    }
}