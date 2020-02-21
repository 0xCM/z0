//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public struct Fixed16 : IFixedNumeric<Fixed16,ushort>, IEquatable<Fixed16>
    {
        public const int BitWidth = 16;

        ushort X0;

        public ushort Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = value;
        }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }

        [MethodImpl(Inline)]
        Fixed16(ushort x)
            => X0 = x;

        public unsafe Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => new Span<byte>(Unsafe.AsPointer(ref Unsafe.AsRef(in this)), BitWidth/8);
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(ushort x)
            => new Fixed16(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(short x)
            => new Fixed16((ushort)x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(int x)
            => new Fixed16((ushort)((short)x));

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(uint x)
            => new Fixed16((ushort)x);

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
        public A As<A>()
            where A : struct
                => Unsafe.As<Fixed16,A>(ref Unsafe.AsRef(in this));             

        [MethodImpl(Inline)]
        public bool Equals(Fixed16 src)
            => X0 == src.X0;

        [MethodImpl(Inline)]
        public bool Equals(ushort src)
            => X0 == src;
       
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed16 x && Equals(x);

        public override string ToString() 
            => X0.ToString();
    }
}