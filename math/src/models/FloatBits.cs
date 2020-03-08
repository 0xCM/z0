//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;    

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct Float32Bits
    {
        [MethodImpl(Inline)]
        public static Float32Bits Define(float src)
            => new Float32Bits(src);

        [MethodImpl(Inline)]
        public Float32Bits(float src)
        {
            this.Integral = 0;
            this.Fractional = src;
        }
        
        [FieldOffset(0)]
        public float Fractional;

        [FieldOffset(0)]
        public uint Integral;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Float64Bits
    {
        const ulong SignMask = 0x7fffffffffffffff;

        [MethodImpl(Inline)]
        public static double Abs(double src)
        {
            var bits = Define(src);
            bits.Integral &= SignMask;
            return bits.Fractional;
        }

        [MethodImpl(Inline)]
        public static Float64Bits Define(double src)
            => new Float64Bits(src);

        [MethodImpl(Inline)]
        public Float64Bits(double src)
        {
            this.Integral = 0;
            this.Fractional = src;
        }
        
        [FieldOffset(0)]
        public double Fractional;

        [FieldOffset(0)]
        public ulong Integral;
    }    
}