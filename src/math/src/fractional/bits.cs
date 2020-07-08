//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static math;    
    
    partial class fmath
    {
        [MethodImpl(Inline), Op]
        public static F32Bits bits(float src)
            => new F32Bits(src);

        [MethodImpl(Inline), Op]
        public static F64Bits bits(double src)
            => new F64Bits(src);

        [MethodImpl(Inline), Op]
        public static F128Bits bits(decimal src)
            => new F128Bits(src);
    }


    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct F32Bits
    {
        public const uint SignMask = 0x7fffffff;

        [FieldOffset(0)]
        public float Data;

        [FieldOffset(0)]
        public uint Bits;

        [MethodImpl(Inline)]
        public F32Bits(float src)
        {
            Bits = 0;
            Data = src;
        }        
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct F64Bits
    {
        public const ulong SignMask = 0x7fffffffffffffff;

        [FieldOffset(0)]
        public double Data;

        [FieldOffset(0)]
        public ulong Bits;

        [MethodImpl(Inline)]
        public F64Bits(double src)
            : this()
        {
            Data = src;
        }    
    }    

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct F128Bits
    {
        [FieldOffset(0)]
        public decimal Data;

        [FieldOffset(0)]
        public ulong LoBits;

        [FieldOffset(8)]
        public ulong HiBits;

        [MethodImpl(Inline)]
        public F128Bits(decimal src)
            : this()
        {
            Data = src;
        }    
    }        
}