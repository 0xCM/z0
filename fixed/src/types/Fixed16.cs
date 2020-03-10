//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection; 

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 Emitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 UnaryOp16(Fixed16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 BinaryOp16(Fixed16 a, Fixed16 b);

    public struct Fixed16 : IFixedNumeric<Fixed16,ushort>, IEquatable<Fixed16>
    {
        public const int BitWidth = 16;

        ushort X0;

        public ushort Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = value;
        }

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public static Fixed16 From(ushort src)
            => new Fixed16(src);

        [MethodImpl(Inline)]
        public static Fixed16 From(short src)
            => new Fixed16((ushort)src);

        [MethodImpl(Inline)]
        public static Fixed16 From(int src)
            => new Fixed16((ushort)(short)src);

        [MethodImpl(Inline)]
        public static Fixed16 From(uint src)
            => new Fixed16((ushort)src);

        [MethodImpl(Inline)]
        Fixed16(ushort x)
            => X0 = x;

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(ushort x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(short x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(int x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(uint x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed16 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed16 x)
            => (byte)x.X0;
        
        [MethodImpl(Inline)]
        public static explicit operator short(Fixed16 x)
            => (short)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed16 x)
            => x.X0;

        [MethodImpl(Inline)]
        public bool Equals(Fixed16 src)
            => X0 == src.X0;

        [MethodImpl(Inline)]
        public bool Equals(ushort src)
            => X0 == src;
       
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed16 x && Equals(x);

        public override string ToString() 
            => X0.ToString();
    }

    partial class FixedNumericOps
    {
        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this short src)
            => src;

        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed(this Func<ushort,ushort> f)
            => (Fixed16 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed(this Func<short,short> f)
            => (Fixed16 a) =>f((short)a.Data);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this Func<short,short,short> f)
            => (Fixed16 a, Fixed16 b) =>f((short)a.Data, (short)b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this Func<ushort,ushort,ushort> f)
            => (Fixed16 a, Fixed16 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixedBinOp(this MethodInfo f, NumericTypeKind<ushort> k)
            => f.CreateDelegate<Func<ushort,ushort,ushort>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixedBinOp(this MethodInfo f, NumericTypeKind<short> k)
            => f.CreateDelegate<Func<short,short,short>>().ToFixed();


    }

}