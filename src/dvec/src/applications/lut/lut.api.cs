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

    [ApiHost]
    public class LUT : IApiHost<LUT>
    {        
        [MethodImpl(Inline), Init]
        public static Lut16 init(Vector128<byte> src) 
            => Lut16.Define(src);

        [MethodImpl(Inline), Init]
        public static Lut16 init(ReadOnlySpan<byte> src, N16 n) 
            => Lut16.Define(src);

        [MethodImpl(Inline), Init]
        public static Lut16 init(in Block128<byte> src) 
            => Lut16.Define(src);

        [MethodImpl(Inline), Init]
        public static Lut32 init(Vector256<byte> src) 
            => Lut32.Define(src);

        [MethodImpl(Inline), Init]
        public static Lut32 init(ReadOnlySpan<byte> src, N32 n) 
            => Lut32.Define(src);

        [MethodImpl(Inline), Init]
        public static Lut32 init(in Block256<byte> src) 
            => Lut32.Define(src);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> select(in Lut16 lut, Vector128<byte> items) 
            => lut.Select(items);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> select(in Lut32 lut, Vector256<byte> items) 
            => lut.Select(items);

    }
}