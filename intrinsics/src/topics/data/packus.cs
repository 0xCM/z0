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
    
    using static zfunc;
    using static HexConst;
    using static Data;

    partial class VData
    {        
        /// <summary>
        /// Produces the lo shuffle spec for packing (128x32, 128x32) -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusLo(N128 w, N32 src, N16 dst)
            => load(w, PackUSLo32x128x16u);

        /// <summary>
        /// Produces the hi shuffle spec for packing (128x32, 128x32) -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusHi(N128 w, N32 src, N16 dst)
            => load(w,PackUSHi32x128x16u);

        /// <summary>
        /// Produces the lo shuffle spec for packing (128x16,128x16) -> 128x8
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusLo(N128 w, N16 src, N8 dst)
            => load(w, PackUSLo16x128x8u);

        /// <summary>
        /// Produces the hi shuffle spec for packing (128x16,128x16) -> 128x8
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusHi(N128 w, N16 src, N8 dst)
            => load(w, PackUSHi16x128x8u);

        [MethodImpl(Inline)]
        public static Vector256<byte> packusLo(N256 w, N16 src, N8 dst)
            => load(w, PackUSLo16x256x8u);

        [MethodImpl(Inline)]
        public static Vector256<byte> packusHi(N256 w, N16 src, N8 dst)
            => load(w, PackUSHi16x256x8u);

        /// <summary>
        /// Retrieves the lo shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> packusLo(N256 w, N32 src, N16 dst)
            => load(w,PackUSLo32x256x16u);

        /// <summary>
        /// Retrieves the hi shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> packusHi(N256 w, N32 src, N16 dst)
            => load(w,PackUSHi32x256x16u);


    }
}