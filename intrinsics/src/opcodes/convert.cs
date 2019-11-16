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

    using static zfunc;    

    partial class inxoc
    {
        public static Vector256<byte> valignr256x4n(Vector256<byte> x, Vector256<byte> y)
            => dinx.valignr(x,y,n4);

        public static Vector256<byte> valignr256x4(Vector256<byte> x, Vector256<byte> y)
            => dinx.valignr(x,y,VAlignR.R4);

        public static Vector128<byte> valignr128x4n(Vector128<byte> x, Vector128<byte> y)
            => dinx.valignr(x,y,n4);

        public static Vector128<byte> valignr128x4(Vector128<byte> x, Vector128<byte> y)
            => dinx.valignr(x,y,VAlignR.R4);

        public static Vector128<byte> packus(Vector128<ushort> x,Vector128<ushort> y)
            => dinx.vpackus(x,y);

        public static Vector256<byte> packus(Vector256<ushort> x,Vector256<ushort> y)
            => dinx.vpackus(x,y);

    }
}