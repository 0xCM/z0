//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [Fixed(FixedWidth.W8,false,FixedWidth.W8)]
    public struct Fixed8 : IFixedNumeric<Fixed8, byte>, IEquatable<Fixed8>
    {        
        byte X0;

        public byte Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = value;
        }

        public int BitWidth  { [MethodImpl(Inline)] get => 8; }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public static Fixed8 From(byte src)
            => new Fixed8(src);

        [MethodImpl(Inline)]
        public static Fixed8 From(sbyte src)
            => new Fixed8((byte)src);

        [MethodImpl(Inline)]
        public static Fixed8 From(int src)
            => new Fixed8((byte)(sbyte)src);

        [MethodImpl(Inline)]
        public static Fixed8 From(uint src)
            => new Fixed8((byte)src);

        [MethodImpl(Inline)]
        public static Fixed8 From<T>(T src)
            where T : unmanaged
                => From(Cast.to<T,byte>(src));

        [MethodImpl(Inline)]
        Fixed8(byte x0)
            => X0 = x0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(byte x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(sbyte x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(int x)
            => new Fixed8((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(uint x)
            => new Fixed8((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed8 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed8 x)
            => (byte)x.X0;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(X0);

        [MethodImpl(Inline)]
        public bool Equals(Fixed8 src)
            => X0 == src.X0;

        [MethodImpl(Inline)]
        public bool Equals(byte src)
            => X0 == src;

        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed8 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}