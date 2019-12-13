//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static HexConst;

    partial class VData
    {        
        /// <summary>
        /// Retrieves the lo shuffle spec for packing 128x32x2 -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusLo(N128 w, N32 src, N16 dst)
            => load(w,PackUS_32Lo_128x16);

        [MethodImpl(Inline)]
        public static Vector128<byte> packusLo(N128 w, N16 src, N8 dst)
            => load(w,PackUS_16Lo_128x8);

        [MethodImpl(Inline)]
        public static Vector128<byte> packusHi(N128 w, N16 src, N8 dst)
            => load(w,PackUS_16Hi_128x8);

        [MethodImpl(Inline)]
        public static Vector256<byte> packusLo(N256 w, N16 src, N8 dst)
            => load(w,PackUS_16Lo_256x8);

        [MethodImpl(Inline)]
        public static Vector256<byte> packusHi(N256 w, N16 src, N8 dst)
            => load(w,PackUS_16Hi_256x8);

        /// <summary>
        /// Retrieves the hi shuffle spec for packing 128x32x2 -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusHi(N128 w, N32 src, N16 dst)
            => load(w,PackUS_32Hi_128x16);

        /// <summary>
        /// Retrieves the lo shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> packusLo(N256 w, N32 src, N16 dst)
            => load(w,PackUS_32Lo_256x16);

        /// <summary>
        /// Retrieves the hi shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> packusHi(N256 w, N32 src, N16 dst)
            => load(w,PackUS_32Hi_256x16);

        static ReadOnlySpan<byte> PackUS_16Lo_128x8
            => new byte[16]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        static ReadOnlySpan<byte> PackUS_16Hi_128x8
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        static ReadOnlySpan<byte> PackUS_32Lo_128x16
            => new byte[16]{
                0,1, 4,5, 8,9, 12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        static ReadOnlySpan<byte> PackUS_32Hi_128x16
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0,1,4,5,8,9,12,13
                };

        static ReadOnlySpan<byte> PackUS_16Lo_256x8
            => new byte[32]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        static ReadOnlySpan<byte> PackUS_16Hi_256x8
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        static ReadOnlySpan<byte> PackUS_32Lo_256x16
            => new byte[32]{
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                };

        static ReadOnlySpan<byte> PackUS_32Hi_256x16
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13,
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13
                };
    }
}