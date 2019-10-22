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

    partial class inxvoc
    {
        public static bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
            => dinx.testz(src,mask);

        public static bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
            => ginx.testz(src,mask);

        public static bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
            => dinx.testz(src,mask);

        public static bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
            => ginx.testz(src,mask);

        public static bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
            => ginx.testz(src,mask);        

        public static bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
            => dinx.testz(src,mask);        

        public static bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
            => ginx.testz(src,mask);         
    }

}