//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;

    public class LUT
    {        
        [MethodImpl(Inline)]
        public static Lut16 define(Vector128<byte> src) => Lut16.Define(src);

        [MethodImpl(Inline)]
        public static Lut16 define(in Block128<byte> src) => Lut16.Define(src);

        [MethodImpl(Inline)]
        public static Lut32 define(Vector256<byte> src) => Lut32.define(src);

        [MethodImpl(Inline)]
        public static Lut32 define(in Block256<byte> src) => Lut32.define(src);
    }
}