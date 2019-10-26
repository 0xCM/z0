//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    
    partial class zfoc
    {
        public static Span<byte> tospan_128x8i(Vector128<byte> src)
            => src.ToSpan();

        public static unsafe void vstore_g128x8u(Vector128<byte> src, ref byte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x8i(Vector128<sbyte> src, ref sbyte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x16i(Vector128<short> src, ref short dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x16u(Vector128<ushort> src, ref ushort dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_d128x16u(Vector128<ushort> src, ref ushort dst)
            => cpuvec.vstore(src, ref dst);

        public static unsafe void vstore_g128x32i(Vector128<int> src, ref int dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x32u(Vector128<uint> src, ref uint dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x64i(Vector128<long> src, ref long dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x64u(Vector128<ulong> src, ref ulong dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x32f(Vector128<float> src, ref float dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g128x64f(Vector128<double> src, ref double dst)
            => vstore(src, ref dst);

         public static unsafe void vstore_g256x8u(Vector256<byte> src, ref byte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x8i(Vector256<sbyte> src, ref sbyte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x16i(Vector256<short> src, ref short dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x16u(Vector256<ushort> src, ref ushort dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x32i(Vector256<int> src, ref int dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x32u(Vector256<uint> src, ref uint dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x64i(Vector256<long> src, ref long dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x64u(Vector256<ulong> src, ref ulong dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x32f(Vector256<float> src, ref float dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_g256x64f(Vector256<double> src, ref double dst)
            => vstore(src, ref dst);


    }

}