//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> transpose<T>(BitGrid64<N8,N8,T> g)        
            where T : unmanaged
        {
            var dst = alloc64<N8,N8,byte>();            
            var src = dinx.vmovscalar(n128,g);
            for(var i=7; i>= 0; i--)
            {
                dst[i] = (byte)dinx.vmovemask(v8u(src));
                src = dinx.vsll(src,1);
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
                => src.Data;

        //  0  1  2  3
        //  4  5  6  7
        //  8  9 10 11
        // 12 13 14 15
        // 16 17 18 19
        // 20 21 22 23
        // 24 25 26 27
        // 28 29 30 31
        // 32 33 34 35 
        // 36 37 38 39
        // 40 41 42 43 
        // 44 45 46 47 
        // 48 49 50 51
        // 52 53 54 55
        // 56 57 58 59
        // 60 61 62 63



        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> transpose2(BitGrid64<N16,N4,ulong> A)
        {
            const ulong C =0b0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001_0001;
            //const ulong R0 =0b0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_1111_1111_1111_1111;
            //const ulong R = (1ul << 16) - 1;
            //var R2 = NatMath.pow2m1<N16>();
            var r = A.RowCount;
            var c = A.ColCount;
            var R = math.pow2m1(r);
            

            

            var c0 = Bits.gather(A.Data, C << 0);
            var c1 = Bits.gather(A.Data, C << 1);
            var c2 = Bits.gather(A.Data, C << 2);
            var c3 = Bits.gather(A.Data, C << 3);
            
            var r0 = Bits.scatter(c0, R << 0*r);
            var r1 = Bits.scatter(c1, R << 1*r);
            var r2 = Bits.scatter(c2, R << 2*r);
            var r3 = Bits.scatter(c3, R << 3*r);
            return r0 | r1 | r2 | r3;
            
        }

        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> transpose(BitGrid64<N16,N4,ulong> A)
            => BitGrid.cells(n64,n4,n16, 
                (ulong)A.Col(0) << 0  | 
                (ulong)A.Col(1) << 16 | 
                (ulong)A.Col(2) << 32 | 
                (ulong)A.Col(3) << 48
                );

    }

}