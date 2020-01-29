//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;    
    using static As;
    
    partial class gfp
    {
        /// <summary>
        /// Computes the absolute value of a primal FP scalar
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T abs<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.abs(float64(src)));
            else
                throw unsupported<T>();
        }        

    }

    
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

    partial class fmath
    {
        const uint Float32SignMask = 0x7fffffff;
        const ulong Float64SignMask = 0x7fffffffffffffff;

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static float abs(float a)
        {
            var bits =  Float32Bits.Define(a);
            bits.Integral &= Float32SignMask;
            return bits.Fractional;
        }

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static double abs(double a)
            => Float64Bits.Abs(a);

    }
}