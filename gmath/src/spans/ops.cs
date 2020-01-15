//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.add<T>(), lhs, rhs, dst);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.mul<T>(), lhs, rhs, dst);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.negate<T>(), src, dst);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.and<T>(), lhs,rhs,dst);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.or<T>(), lhs, rhs, dst);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.xor<T>(), lhs, rhs, dst);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.not<T>(), src, dst);


        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<T> pow<T>(ReadOnlySpan<T> src, uint exp, Span<T> dst)
            where T : unmanaged
        {
            var count = dst.Length;
            ref readonly var bases = ref head(src);
            ref var results = ref head(dst);

            for(var i = 0; i<count; i++) 
                seek(ref results,i) = gmath.pow(skip(bases,i), exp);
            
            return dst;
        }
    }
}