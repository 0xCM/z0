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

    public static class LUT
    {        

        [MethodImpl(Inline)]
        public static Lut16 define(Vector128<byte> src)
            => new Lut16(src);

        [MethodImpl(Inline)]
        public static Lut16 define(ConstBlock128<byte> src)
            => new Lut16(src);

        [MethodImpl(Inline)]
        public static Lut32 define(Vector256<byte> src)
            => new Lut32(src);

        [MethodImpl(Inline)]
        public static Lut32 define(ConstBlock256<byte> src)
            => new Lut32(src);
    }
}