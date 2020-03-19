//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Fixed(FixedWidth.W32,false, FixedWidth.NumericWidths)]
    public struct Fixed64 : IFixedNumeric<Fixed64,ulong>, IEquatable<Fixed64>
    {
        public const int BitWidth = 64;        

        ulong X0;

        public ulong Data
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
        public static Fixed64 From<T>(T src)
            where T : unmanaged
                => From(Cast.to<T,ulong>(src));

        [MethodImpl(Inline)]
        public static Fixed64 From(int src)
            => new Fixed64((ulong)(long)src);

        [MethodImpl(Inline)]
        public static Fixed64 From(ulong src)
            => new Fixed64(src);

        [MethodImpl(Inline)]
        public static Fixed64 From(long src)
            => new Fixed64((ulong)src);

        [MethodImpl(Inline)]
        Fixed64(ulong x0)
            => X0 = x0;
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed64(int x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(long x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(ulong x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed64 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed64 x)
            => (byte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator short(Fixed64 x)
            => (short)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed64 x)
            => (ushort)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed64 x)
            => (uint)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed64 x)
            => (int)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed64 x)
            => (long)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed64 x)
            => x.X0;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(X0);

        [MethodImpl(Inline)]
        public bool Equals(ulong src)
            => X0 == src;

        [MethodImpl(Inline)]
        public bool Equals(Fixed64 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed64 x && Equals(x);

        public override string ToString() 
            => X0.ToString();
    }
}