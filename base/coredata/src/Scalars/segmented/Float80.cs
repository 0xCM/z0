//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines a 64-bit floating-point number
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 10)]
    public struct Float80
    {
        [FieldOffset(0)]
        double x64f;

        [FieldOffset(0)]
        ulong x64u;

        [FieldOffset(8)]
        ushort x16u;

        [FieldOffset(0)]
        float x32f;

        [FieldOffset(0)]
        byte x0000;

        [FieldOffset(1)]
        byte x0001;

        [FieldOffset(2)]
        byte x0010;

        [FieldOffset(3)]
        byte x0011;

        [FieldOffset(4)]
        byte x0100;

        [FieldOffset(5)]
        byte x0101;

        [FieldOffset(6)]
        byte x0110;

        [FieldOffset(7)]
        byte x0111;

        [FieldOffset(8)]
        byte x1000;

        [FieldOffset(9)]
        byte x1001;

        [MethodImpl(Inline)]
        public static Float80 From(double src)
            => new Float80(src);

        [MethodImpl(Inline)]
        public static Float80 From(float src)
            => new Float80(src);

        [MethodImpl(Inline)]
        public static implicit operator Float80(double src)
            => new Float80(src);

        [MethodImpl(Inline)]
        public static implicit operator Float80(float src)
            => new Float80(src);

        [MethodImpl(Inline)]
        public static implicit operator double(Float80 src)
            => src.x64f;

        [MethodImpl(Inline)]
        public static implicit operator float(Float80 src)
            => src.x32f;

        [MethodImpl(Inline)]
        public Float80(double src)
            : this()
        {
            this.x64f = src;
        }

        [MethodImpl(Inline)]
        public Float80(float src)
            : this()
        {
            this.x32f = src;
        }

        [MethodImpl(Inline)]
        public bool Equals(Float80 rhs)
            => x64u == rhs.x64u && x16u == rhs.x16u;

        public override bool Equals(object obj)
            => obj is Float80 x && Equals(x);

        public override int GetHashCode()
            => HashCode.Combine(x64u, x16u);

        public override string ToString() 
            => x64f.ToString();

        public string ToString(string format) 
            => x64f.ToString(format);

        public string ToString(IFormatProvider format) 
            => x64f.ToString(format);
    }
}