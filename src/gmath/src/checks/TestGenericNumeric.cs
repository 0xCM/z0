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

    /// <summary>
    /// Determines whether generic numeric assertions are true
    /// </summary>
    public readonly struct TestGenericNumeric
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit nonzero<T>(T x)
            where T : unmanaged
                => gmath.nonz(x);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit zero<T>(T x)
            where T : unmanaged
                => !gmath.nonz(x);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit eq<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.eq(lhs,rhs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit gt<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.gt(lhs,rhs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit gteq<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.gt(lhs,rhs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit lt<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.lt(lhs,rhs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit lteq<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.lteq(lhs,rhs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var count = lhs.Length;
            if(count != rhs.Length)
                return false;
            for(var i=0; i<count; i++)
                if(!eq(skip(lhs,i), skip(rhs,i)))
                    return false;
            return true;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit eq<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => eq(@readonly(lhs), @readonly(rhs));
    }
}
