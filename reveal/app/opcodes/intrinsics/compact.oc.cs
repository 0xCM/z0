//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static zfunc;    

    partial class inxoc
    {
        public static Vector128<byte> vcompact_128x16x2_128x8_v1(Vector128<ushort> x0, Vector128<ushort> x1)
            => dinx.vcompact(x0,x1);

        public static Vector256<byte> vcompact_256x16x2_256x8_v1(Vector256<ushort> x0, Vector256<ushort> x1)
            => dinx.vcompact(x0,x1);

        public static Vector128<ushort> vcompact_128x32x2_128x16_v1(Vector128<uint> x, Vector128<uint> y)
            => dinx.vcompact(x,y);

        public static Vector128<ushort> vcompact_128x32x2_128x16_v2(Vector128<uint> x, Vector128<uint> y)
            => dinx.vcompact2(x,y);

        public static Vector256<ushort> vcompact_256x32x2_128x16_v1(Vector256<uint> x, Vector256<uint> y)
            => dinx.vcompact(x,y);

        public static Vector256<ushort> vcompact_256x32x2_128x16_v2(Vector256<uint> x, Vector256<uint> y)
            => dinx.vcompact2(x,y);


        
    }
}