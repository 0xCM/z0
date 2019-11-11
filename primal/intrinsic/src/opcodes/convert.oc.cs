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

        public static Vector128<byte> packus(Vector128<ushort> x,Vector128<ushort> y)
            => dinx.vpackus(x,y);

        public static Vector256<byte> packus(Vector256<ushort> x,Vector256<ushort> y)
            => dinx.vpackus(x,y);

    }
}