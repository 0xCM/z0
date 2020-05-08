//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [Fixed(FixedWidth.W64)]
    public readonly struct Fixed64 : IFixedNumeric<Fixed64,W64,ulong>
    {
        internal readonly ulong Data;

        public ulong Content
        {
            [MethodImpl(Inline)] get => Data;
        }

        public Fixed32 Lo
        {
            [MethodImpl(Inline)]
            get => (uint)Data;
        }

        public Fixed32 Hi
        {
            [MethodImpl(Inline)]
            get => (uint)(Data >> 32);
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
            => Data = x0;
        

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
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed64 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Fixed64 x)
            => (short)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed64 x)
            => (ushort)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed64 x)
            => (uint)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed64 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed64 x)
            => (long)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed64 x)
            => x.Data;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(ulong src)
            => Data == src;

        [MethodImpl(Inline)]
        public bool Equals(Fixed64 src)
            => Data == src.Data;     
        public string Format()
            => Data.ToString();

        public override string ToString() 
            => Format();
 
         public override int GetHashCode()
            => Data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed64 x && Equals(x);
   }
}