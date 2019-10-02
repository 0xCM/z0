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
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class inxvoc
    {
        public static bool vtestz_n128x8u(Vec128<byte> src, Vec128<byte> mask)
            => TestZ(src.xmm, mask.xmm);        

        public static bool vtestz_d128x8i(Vec128<sbyte> src, Vec128<sbyte> mask)
            => dinx.testz(src,mask);

        public static bool vtestz_g128x8i(Vec128<sbyte> src, Vec128<sbyte> mask)
            => ginx.testz(src,mask);

        public static bool vtestz_d128x8u(Vec128<byte> src, Vec128<byte> mask)
            => dinx.testz(src,mask);

        public static bool vtestz_g128x8u(Vec128<byte> src, Vec128<byte> mask)
            => ginx.testz(src,mask);

        public static bool vtestz_d128x16i(Vec128<short> src, Vec128<short> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x16i(Vec128<short> src, Vec128<short> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x16u(Vec128<ushort> src, Vec128<ushort> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x16u(Vec128<ushort> src, Vec128<ushort> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x32i(Vec128<int> src, Vec128<int> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x32i(Vec128<int> src, Vec128<int> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x32u(Vec128<uint> src, Vec128<uint> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x32u(Vec128<uint> src, Vec128<uint> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x64i(Vec128<long> src, Vec128<long> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x64i(Vec128<long> src, Vec128<long> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x64u(Vec128<ulong> src, Vec128<ulong> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x64u(Vec128<ulong> src, Vec128<ulong> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x8i(Vec256<sbyte> src, Vec256<sbyte> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x8i(Vec256<sbyte> src, Vec256<sbyte> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x8u(Vec256<byte> src, Vec256<byte> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x8u(Vec256<byte> src, Vec256<byte> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x16i(Vec256<short> src, Vec256<short> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x16i(Vec256<short> src, Vec256<short> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x16u(Vec256<ushort> src, Vec256<ushort> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x16u(Vec256<ushort> src, Vec256<ushort> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x32i(Vec256<int> src, Vec256<int> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x32i(Vec256<int> src, Vec256<int> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x32u(Vec256<uint> src, Vec256<uint> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x32u(Vec256<uint> src, Vec256<uint> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x64i(Vec256<long> src, Vec256<long> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x64i(Vec256<long> src, Vec256<long> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x64u(Vec256<ulong> src, Vec256<ulong> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x64u(Vec256<ulong> src, Vec256<ulong> mask)
            => ginx.testz(src,mask);         
    }

}