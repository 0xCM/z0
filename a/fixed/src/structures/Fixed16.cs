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
        readonly ushort X0;

        public ushort Data
        {
            [MethodImpl(Inline)] get => X0;
        }

        public int BitWidth => 16;

        public int ByteCount => 2;

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
        public static Fixed16 From<T>(T src)
            where T : unmanaged
                => From(Cast.to<T,ushort>(src));

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
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(X0);

        [MethodImpl(Inline)]
        public bool Equals(Fixed16 src)
            => X0 == src.X0;

        public string Format()
            => X0.ToString();

        public override string ToString() 
            => Format();
 
        [MethodImpl(Inline)]
        public bool Equals(ushort src)
            => X0 == src;
       
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed16 x && Equals(x);

   }
}