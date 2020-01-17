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
            => load(w, PackUS32Lo128x16);

        /// <summary>
        /// Produces the hi shuffle spec for packing (128x32, 128x32) -> 128x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusHi(N128 w, N32 src, N16 dst)
            => load(w,PackUS32Hi128x16);

        /// <summary>
        /// Produces the lo shuffle spec for packing (128x16,128x16) -> 128x8
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusLo(N128 w, N16 src, N8 dst)
            => load(w, PackUS16Lo128x8);

        /// <summary>
        /// Produces the hi shuffle spec for packing (128x16,128x16) -> 128x8
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> packusHi(N128 w, N16 src, N8 dst)
            => load(w, PackUS16Hi128x8);

        [MethodImpl(Inline)]
        public static Vector256<byte> packusLo(N256 w, N16 src, N8 dst)
            => load(w, PackUS16Lo256x8);

        [MethodImpl(Inline)]
        public static Vector256<byte> packusHi(N256 w, N16 src, N8 dst)
            => load(w, PackUS16Hi256x8);

        /// <summary>
        /// Retrieves the lo shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> packusLo(N256 w, N32 src, N16 dst)
            => load(w,PackUS32Lo256x16);

        /// <summary>
        /// Retrieves the hi shuffle spec for packing 256x32x2 -> 256x16
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source cell width selector</param>
        /// <param name="dst">The target cell width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> packusHi(N256 w, N32 src, N16 dst)
            => load(w,PackUS32Hi256x16);


    }
}