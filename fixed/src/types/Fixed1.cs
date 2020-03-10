//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;


    public struct Fixed1 : IFixed, IEquatable<Fixed1>
    {
        public const int BitWidth = 1;

        const uint Mask = 1;

        byte X0;

        public int FixedBitCount 
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }

        public byte Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = (byte)((uint)value & Mask);
        }

        [MethodImpl(Inline)]
        public static Fixed1 From(byte src)
            => new Fixed1(src);

        [MethodImpl(Inline)]
        public static Fixed1 From(bit b0)
            => new Fixed1((uint)b0);

        [MethodImpl(Inline)]
        Fixed1(uint x0)
            => X0 = (byte)(x0 & 1);

        [MethodImpl(Inline)]
        Fixed1(byte x0)
            => X0 = (byte)((uint)x0 & 1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed1(bit x)
            => new Fixed1((uint)x);

        [MethodImpl(Inline)]
        public static implicit operator bit(Fixed1 x)
            => (bit)x;

        [MethodImpl(Inline)]
        public static explicit operator Fixed1(byte x)
            => new Fixed1(x);

        [MethodImpl(Inline)]
        public static implicit operator byte(Fixed1 x)
            => x.X0;
        
        [MethodImpl(Inline)]
        public bool Equals(Fixed1 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed1 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}