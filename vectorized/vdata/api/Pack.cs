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
    
    using static Core;
    using static HexConst;
 
    partial class Data
    {
        /// <summary>
        /// Produces the lo shuffle spec for packing (128x32, 128x32) -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> packusLo(N128 w, N32 src, N16 dst)
            => vload(w, PackUSLo32x128x16u);

        /// <summary>
        /// Produces the hi shuffle spec for packing (128x32, 128x32) -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> packusHi(N128 w, N32 src, N16 dst)
            => vload(w,PackUSHi32x128x16u);

        /// <summary>
        /// Produces the lo shuffle spec for packing (128x16,128x16) -> 128x8
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> packusLo(N128 w, N16 src, N8 dst)
            => vload(w, PackUSLo16x128x8u);

        /// <summary>
        /// Produces the hi shuffle spec for packing (128x16,128x16) -> 128x8
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> packusHi(N128 w, N16 src, N8 dst)
            => vload(w, PackUSHi16x128x8u);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> packusLo(N256 w, N16 src, N8 dst)
            => vload(w, PackUSLo16x256x8u);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> packusHi(N256 w, N16 src, N8 dst)
            => vload(w, PackUSHi16x256x8u);

        /// <summary>
        /// Retrieves the lo shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> packusLo(N256 w, N32 src, N16 dst)
            => vload(w,PackUSLo32x256x16u);

        /// <summary>
        /// Retrieves the hi shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> packusHi(N256 w, N32 src, N16 dst)
            => vload(w,PackUSHi32x256x16u);

        public static ReadOnlySpan<byte> PackUSLo16x128x8u
            => new byte[16]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUSLo32x128x16u
            => new byte[16]{
                0,1, 4,5, 8,9, 12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUSLo16x256x8u
            => new byte[32]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUSLo32x256x16u
            => new byte[32]{
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                };

        public static ReadOnlySpan<byte> PackUSHi16x128x8u
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        public static ReadOnlySpan<byte> PackUSHi32x128x16u
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0,1,4,5,8,9,12,13
                };

        public static ReadOnlySpan<byte> PackUSHi16x256x8u
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        public static ReadOnlySpan<byte> PackUSHi32x256x16u
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13,
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13
                };                

        [ResourceProvider]
        static void RegisterPacks()
        {
            var name = string.Empty;
            var index = PackIndex;


            name = "PackUSLo";
            Register(index++, Identify.Resource(name, w16, w128, NumericKind.U8), PackUSLo16x128x8u);
            Register(index++, Identify.Resource(name, w32, w128, NumericKind.U16), PackUSLo32x128x16u);
            Register(index++, Identify.Resource(name, w16, w256, NumericKind.U8), PackUSLo16x256x8u);
            Register(index++, Identify.Resource(name, w32, w256, NumericKind.U16), PackUSLo32x256x16u);

            name = "PackUSHi";
            Register(index++, Identify.Resource(name, w16, w128, NumericKind.U8), PackUSHi16x128x8u);
            Register(index++, Identify.Resource(name, w32, w128, NumericKind.U16), PackUSHi32x128x16u);
            Register(index++, Identify.Resource(name, w16, w256, NumericKind.U8), PackUSHi16x256x8u);
            Register(index++, Identify.Resource(name, w32, w256, NumericKind.U16), PackUSHi32x256x16u);
        }
    }
}