//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public struct Fixed3 : IFixed, IEquatable<Fixed3>
    {
        public const int BitWidth = 3;

        const uint Mask = 0b111;

        byte X0;

        public byte Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = (byte)((uint)value & Mask);
        }

        public int BitCount 
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }

        [MethodImpl(Inline)]
        public static Fixed3 From(byte src)
            => new Fixed3(src);

        [MethodImpl(Inline)]
        public static Fixed3 From(bit b0, bit b1, bit b2)
            => new Fixed3(((uint)b2 << 2) | ((uint)b1 << 1) | (uint)b0);

        [MethodImpl(Inline)]
        Fixed3(byte x0)
            => X0 = (byte)((uint)x0 & Mask);

        [MethodImpl(Inline)]
        Fixed3(uint x0)
            => X0 = (byte)(x0 & Mask);

        [MethodImpl(Inline)]
        public static explicit operator Fixed3(byte x)
            => new Fixed3(x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed3(sbyte x)
            => new Fixed3((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed3(int x)
            => new Fixed3((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed3(uint x)
            => new Fixed3((byte)x);

        [MethodImpl(Inline)]
        public static implicit operator sbyte(Fixed3 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static implicit operator byte(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator short(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator ushort(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator int(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator uint(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator long(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator ulong(Fixed3 x)
            => x.X0;

        [MethodImpl(Inline)]
        public bool Equals(Fixed3 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed3 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}