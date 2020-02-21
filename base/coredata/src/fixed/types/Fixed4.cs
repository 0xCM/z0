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

    public struct Fixed4 : IFixed, IEquatable<Fixed4>
    {
        public const int BitWidth = 4;

        const uint Mask = 0xFu;

        byte X0;

        public byte Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = (byte)((uint)value & Mask);
        }

        public int BitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        public static Fixed4 From(byte src)
            => new Fixed4(src);

        [MethodImpl(Inline)]
        Fixed4(byte x0)
            => X0 = (byte)((uint)x0 & Mask);

        [MethodImpl(Inline)]
        public static implicit operator Fixed4(uint4_t x)
            => new Fixed4((byte)x);

        [MethodImpl(Inline)]
        public static implicit operator uint4_t(Fixed4 x)
            => uint4_t.From(x.X0);

        [MethodImpl(Inline)]
        public static explicit operator Fixed4(byte x)
            => new Fixed4(x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed4(sbyte x)
            => new Fixed4((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed4(int x)
            => new Fixed4((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed4(uint x)
            => new Fixed4((byte)x);

        [MethodImpl(Inline)]
        public static implicit operator sbyte(Fixed4 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static implicit operator byte(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator short(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator ushort(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator int(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator uint(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator long(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static implicit operator ulong(Fixed4 x)
            => x.X0;

        [MethodImpl(Inline)]
        public bool Equals(Fixed4 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed4 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}