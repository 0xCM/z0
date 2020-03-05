//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    [OpCodeProvider]
    public static class vcompare
    {                

        public static Vector128<int> vlt_128x32i(Vector128<int> x, Vector128<int> y)
            => dinx.vlt(x,y);

        public static Vector128<int> vlt_g128x32i(Vector128<int> x, Vector128<int> y)
            => ginx.vlt(x,y);

        public static Vector128<int> vlt_o128x32i(Vector128<int> x, Vector128<int> y)
            => Pipes.apply(x,y, VF.vlt(n128,z32i));

        public static Vector128<uint> vlt_128x32u(Vector128<uint> x, Vector128<uint> y)
            => dinx.vlt(x,y);

        public static Vector128<uint> vlt_g128x32u(Vector128<uint> x, Vector128<uint> y)
            => ginx.vlt(x,y);

        public static Vector128<uint> vlt_o128x32u(Vector128<uint> x, Vector128<uint> y)
            => Pipes.apply(x,y, VF.vlt(n128,z32));

        public static Vector128<long> vlt_128x64i(Vector128<long> x, Vector128<long> y)
            => dinx.vlt(x,y);

        public static Vector128<long> vlt_g128x64i(Vector128<long> x, Vector128<long> y)
            => ginx.vlt(x,y);

        public static Vector128<long> vlt_o128x64i(Vector128<long> x, Vector128<long> y)
            => Pipes.apply(x,y, VF.vlt(n128,z64i));

        public static Vector256<byte> vlt_256x8u(Vector256<byte> x, Vector256<byte> y)
            => dinx.vlt(x,y);

        public static Vector256<byte> vlt_g256x8u(Vector256<byte> x, Vector256<byte> y)
            => ginx.vlt(x,y);

        public static Vector256<byte> vlt_o256x8u(Vector256<byte> x, Vector256<byte> y)
            => Pipes.apply(x,y, VF.vlt(n256,z8));

        public static bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
            => dinx.vtestz(src,mask);

        public static bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
            => ginx.vtestz(src,mask);

        public static bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
            => dinx.vtestz(src,mask);

        public static bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
            => ginx.vtestz(src,mask);

        public static bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
            => ginx.vtestz(src,mask);        

        public static bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
            => dinx.vtestz(src,mask);        

        public static bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
            => ginx.vtestz(src,mask);         

    }
}