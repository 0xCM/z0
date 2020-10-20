//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        static void require(bool invariant, in Func<string> f)
        {
            if(!invariant)
                sys.@throw(f);
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static T[] insist<T>(T[] src)
        {
            if(src is null)
                sys.@throw(AppErrors.NullArg());
            return src;
        }

        [MethodImpl(NotInline)]
        public static int insist<A,B>(A[] a, B[] b)
        {
            if(a == null || b == null)
                sys.@throw(AppErrors.NullArg());
            var length = a.Length;
            if(length != b.Length)
                z.@throw(AppErrors.LengthMismatch(a.Length, b.Length));
            return length;
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static IEnumerable<T> insist<T>(IEnumerable<T> src)
        {
            require(src != null, AppErrors.NullArg);
            return src;
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static void insist<T>(T lhs, T rhs)
            where T : IEquatable<T>
        {
            if(z.nullnot(lhs) && z.nullnot(rhs) && lhs.Equals(rhs))
                return;

            require(false, () => AppErrors.neq<T>(lhs,rhs));
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static T insist<T>(T src, Func<T,bool> f)
        {
            require(f(src),  () => AppErrors.NotTrue(src));
            return src;
        }
    }
}