//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static Konst;

    partial struct z
    {                            
        [MethodImpl(Inline)]
        public static byte vextract<N>(Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat        
                => vextract(n0,src,n);

        [MethodImpl(Inline)]
        static byte vextract<N>(N0 first, Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat        
        {
            if(typeof(N) == typeof(N0))
                return Extract(src, 0);
            else if(typeof(N) == typeof(N1))
                return Extract(src, 1);
            else if(typeof(N) == typeof(N2))
                return Extract(src, 2);
            else if(typeof(N) == typeof(N3))
                return Extract(src, 3);
            else if(typeof(N) == typeof(N4))
                return Extract(src, 4);
            else
                return vextract(n5, src, n);
        }

        [MethodImpl(Inline)]
        static byte vextract<N>(N5 first, Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat        
        {
            if(typeof(N) == typeof(N5))
                return Extract(src, 5);
            else if(typeof(N) == typeof(N6))
                return Extract(src, 6);
            else if(typeof(N) == typeof(N7))
                return Extract(src, 7);
            else if(typeof(N) == typeof(N8))
                return Extract(src, 8);
            else if(typeof(N) == typeof(N9))
                return Extract(src, 9);
            else
                return vextract(n10, src, n);
        }

        [MethodImpl(Inline)]
        static byte vextract<N>(N10 first, Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat        
        {
            if(typeof(N) == typeof(N10))
                return Extract(src, 10);
            else if(typeof(N) == typeof(N11))
                return Extract(src, 11);
            else if(typeof(N) == typeof(N12))
                return Extract(src, 12);
            else if(typeof(N) == typeof(N13))
                return Extract(src, 13);
            else if(typeof(N) == typeof(N14))
                return Extract(src, 14);
            else if(typeof(N) == typeof(N14))
                return Extract(src, 15);
            else
                throw Unsupported.define<N>();
        }
    }
}