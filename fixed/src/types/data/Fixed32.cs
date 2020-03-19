//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Fixed(FixedWidth.W32,false,FixedWidth.W8 | FixedWidth.W16 | FixedWidth.W32)]
    public struct Fixed32 : IFixedNumeric<Fixed32,uint>, IEquatable<Fixed32>
    {
        public const int BitWidth = 32;        

        uint X0;

        public uint Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = value;
        }

        public int FixedBitCount
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
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
            => X0 = x0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(uint x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(int x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed32 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed32 x)
            => (byte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator short(Fixed32 x)
            => (short)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed32 x)
            => (ushort)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed32 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed32 x)
            => (int)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed32 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed32 x)
            => (ulong)x.X0;

 
        [MethodImpl(Inline)]
        public T As<T>()
            where T : unmanaged
                => Cast.to<T>(X0);

        [MethodImpl(Inline)]
        public bool Equals(Fixed32 src)
            => X0 == src.X0;

        [MethodImpl(Inline)]
        public bool Equals(uint src)
            => X0 == src;
       
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed32 x && Equals(x);

        public override string ToString() 
            => X0.ToString();
    }
}