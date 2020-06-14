//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [Fixed(FixedWidth.W8)]
    public readonly struct Fixed8 : IFixedNumeric<Fixed8,W8,byte>
    {        
        public static Fixed8 Empty => default(Fixed8);        

        internal readonly byte Data;

        public byte Content
        {
            [MethodImpl(Inline)] 
            get => Data;
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

        public Fixed8 Zero 
        {
            [MethodImpl(Inline)]
            get => Empty; 
        }

        [MethodImpl(Inline)]
        Fixed8(byte x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public static implicit operator byte(Fixed8 src)
            => (byte)src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(byte src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(sbyte x0)
            => From(x0);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed16(Fixed8 x)
            => Fixed16.From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(Fixed8 x)
            => Fixed32.From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(Fixed8 x)
            => Fixed64.From(x.Data);

        [MethodImpl(Inline)]
        public static explicit operator Fixed8(int x)
            => new Fixed8((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static explicit operator Fixed8(uint x)
            => new Fixed8((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed8 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed8 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed8 x)
            => (uint)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed8 x)
            => (long)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed8 x)
            => (ulong)x.Data;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Fixed8 src)
            => Data == src.Data;

        [MethodImpl(Inline)]
        public bool Equals(byte src)
            => Data == src;

        public string Format()
            => Data.ToString();

        public override string ToString() 
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed8 x && Equals(x);    
    }
}