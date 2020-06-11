//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [Fixed(FixedWidth.W16)]
    public readonly struct Fixed16 : IFixedNumeric<Fixed16,W16,ushort>
    {
        public static Fixed16 Empty => default(Fixed16);        

        internal readonly ushort Data;
        
        public ushort Content
        {
            [MethodImpl(Inline)] 
            get => Data;
        }

        public Fixed8 Lo
        {
            [MethodImpl(Inline)]
            get => (byte)Data;
        }

        public Fixed8 Hi
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 8);
        }

        public Fixed16 Zero 
        {
            [MethodImpl(Inline)]
            get => Empty; 
        }

        [MethodImpl(Inline)]
        public static Fixed16 From(ushort src)
            => new Fixed16(src);

        [MethodImpl(Inline)]
        public static Fixed16 From(Fixed8 src)
            => new Fixed16(src.Data);

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
            => Data = x;

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
        public static implicit operator Fixed16(byte x)
            => From((ushort)x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(Fixed8 x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(uint x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed16 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed16 x)
            => (byte)x.Data;
        
        [MethodImpl(Inline)]
        public static explicit operator short(Fixed16 x)
            => (short)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Fixed16 src)
            => Data == src.Data;

        public string Format()
            => Data.ToString();

        public override string ToString() 
            => Format();
 
        [MethodImpl(Inline)]
        public bool Equals(ushort src)
            => Data == src;
       
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed16 x && Equals(x);
   }
}