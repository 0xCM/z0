//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class PrimalX
    {
        [MethodImpl(Inline)]
        public static bit Is<T>(this PrimalKind kind, T t = default)
            where T : unmanaged
                => Primitive.iskind(kind,t);

        [MethodImpl(Inline)]
        public static PrimalKind Kind(this Type t)
            => Primitive.kind(t);

        [MethodImpl(Inline)]
        public static bit Is(this Type t, PrimalKind kind)
            => (Primitive.kind(t) & kind) != 0;

        [MethodImpl(Inline)]
        public static int BitWidth(this PrimalKind k)
            => Primitive.bitsize(k);

        [MethodImpl(Inline)]
        public static char Indicator(this PrimalKind k)
            => Primitive.indicator(k);

        public static string Format(this PrimalKind k)
            => $"{k.BitWidth()}{k.Indicator()}";
    }

}