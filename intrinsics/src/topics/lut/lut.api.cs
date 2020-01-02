//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static Lut16 define(Block128<byte> src)
            => new Lut16(src);

        [MethodImpl(Inline)]
        public static Lut32 define(Vector256<byte> src)
            => new Lut32(src);

        [MethodImpl(Inline)]
        public static Lut32 define(Block256<byte> src)
            => new Lut32(src);
    }
}