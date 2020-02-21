//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Fixed5 : IFixed, IEquatable<Fixed5>
    {
        public const int BitWidth = 5;

        const uint Mask = 0b11111;

        byte X0;

        public byte Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = (byte)((uint)value & Mask);
        }

        public int BitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        public static Fixed5 From(byte src)
            => new Fixed5(src);

        [MethodImpl(Inline)]
        Fixed5(byte x0)
            => X0 = (byte)((uint)x0 & Mask);

        [MethodImpl(Inline)]
        public static explicit operator Fixed5(byte x)
            => new Fixed5(x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed5(sbyte x)
            => new Fixed5((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed5(int x)
            => new Fixed5((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed5(uint x)
            => new Fixed5((byte)x);

        [MethodImpl(Inline)]
        public static implicit operator sbyte(Fixed5 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static implicit operator byte(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator short(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator ushort(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator int(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator uint(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator long(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator ulong(Fixed5 x)
            => x.X0;

        [MethodImpl(Inline)]
        public bool Equals(Fixed5 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed5 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}