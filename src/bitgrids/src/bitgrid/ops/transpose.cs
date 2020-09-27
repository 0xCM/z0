//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class BitGrid
    {
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> transpose<T>(BitGrid64<N8,N8,T> g)
            where T : unmanaged
        {
            var dst = alloc64<N8,N8,byte>();
            var src = Vectors.vscalar(n128,g);
            for(var i=7; i>= 0; i--)
            {
                dst.Cell(i) = (byte)z.vtakemask(v8u(src));
                src = z.vsll(src,1);
            }
            return dst.As<T>();
        }

        [MethodImpl(Inline)]
        internal static BitGrid128<P,Q,T> resize<M,N,P,Q,T>(in BitGrid128<M,N,T> src, P p = default, Q q = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where P : unmanaged, ITypeNat
            where Q : unmanaged, ITypeNat
            where T : unmanaged
                => src.Content;


        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> transpose2(BitGrid64<N16,N4,ulong> A)
        {
            const ulong C =0b0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001;
            var r = A.RowCount;
            var c = A.ColCount;
            var R = math.pow2m1(r);

            var c0 = Bits.gather(A.Content, C << 0);
            var c1 = Bits.gather(A.Content, C << 1);
            var c2 = Bits.gather(A.Content, C << 2);
            var c3 = Bits.gather(A.Content, C << 3);

            var r0 = Bits.scatter(c0, R << 0*r);
            var r1 = Bits.scatter(c1, R << 1*r);
            var r2 = Bits.scatter(c2, R << 2*r);
            var r3 = Bits.scatter(c3, R << 3*r);
            return r0 | r1 | r2 | r3;

        }

        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> transpose(BitGrid64<N16,N4,ulong> A)
            => BitGrid.create(n64,n4,n16,
                (ulong)A.Col(0) << 0  |
                (ulong)A.Col(1) << 16 |
                (ulong)A.Col(2) << 32 |
                (ulong)A.Col(3) << 48
                );

        [MethodImpl(Inline)]
        static Vector256<T> gcell<T>(in Vector256<T> g, int index, T data)
            where T : unmanaged
                => g.WithElement(index, data);

        [MethodImpl(Inline)]
        static Vector256<T> vT16x16step<T>(in Vector256<T> src, in Vector256<T> g0, int i, int j)
            where T : unmanaged
        {
            const uint E = BitMasks.Literals.Even32;
            const uint O = BitMasks.Literals.Odd32;

            var mask = gvec.vtakemask(src, (byte)i);
            var gT = gcell(g0, i, force<T>(Bits.gather(mask, E)));
            gT = gcell(gT, j, force<T>(Bits.gather(mask, O)));
            return gT;
        }

        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,ushort> transpose(in BitGrid256<N16,N16,ushort> g)
        {
            var gT = default(Vector256<ushort>);
            var src = g.Content;

            gT = vT16x16step(src, gT, 0, 8);
            gT = vT16x16step(src, gT, 1, 9);
            gT = vT16x16step(src, gT, 2, 10);
            gT = vT16x16step(src, gT, 3, 11);
            gT = vT16x16step(src, gT, 4, 12);
            gT = vT16x16step(src, gT, 5, 13);
            gT = vT16x16step(src, gT, 6, 14);
            gT = vT16x16step(src, gT, 7, 15);

            return load(gT,n16,n16);
        }
    }
}