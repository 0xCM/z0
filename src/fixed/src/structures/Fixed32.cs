//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [Fixed(FixedWidth.W32)]
    public readonly struct Fixed32 : IFixedNumeric<Fixed32,W32,uint>
    {
        public static Fixed32 Empty => default(Fixed32);        

        internal readonly uint Data;

        public uint Content
        {
            [MethodImpl(Inline)] get => Data;
        }

        public Fixed16 Lo
        {
            [MethodImpl(Inline)]
            get => (ushort)Data;
        }

        public Fixed16 Hi
        {
            [MethodImpl(Inline)]
            get => (ushort)(Data >> 16);
        }

        public Fixed32 Zero 
        {
            [MethodImpl(Inline)]
            get => Empty; 
        }

        [MethodImpl(Inline)]
        public static Fixed32 From(uint src)
            => new Fixed32(src);

        [MethodImpl(Inline)]
        public static Fixed32 From(int src)
            => new Fixed32((uint)src);

        [MethodImpl(Inline)]
        public static Fixed32 From<T>(T src)
            where T : unmanaged
                => From(Cast.to<T,uint>(src));

        [MethodImpl(Inline)]
        Fixed32(uint x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(uint x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(int x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed32 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed32 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Fixed32 x)
            => (short)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed32 x)
            => (ushort)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed32 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed32 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed32 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed32 x)
            => (ulong)x.Data;

 
        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Fixed32 src)
            => Data == src.Data;

        [MethodImpl(Inline)]
        public bool Equals(uint src)
            => Data == src;
       
        public string Format()
            => Data.ToString();

        public override string ToString() 
            => Format();
 
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed32 x && Equals(x);

    }
}