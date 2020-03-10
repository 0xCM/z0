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

    public struct Fixed2 : IFixed, IEquatable<Fixed2>
    {
        public const int BitWidth = 2;

        const uint Mask = 0b11;

        byte X0;

        public byte Data
        {
            [MethodImpl(Inline)] get => X0;
            [MethodImpl(Inline)] set => X0 = (byte)((uint)value & Mask);
        }

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        public static Fixed2 From(byte src)
            => new Fixed2(src);

        [MethodImpl(Inline)]
        public static Fixed2 From(bit b0, bit b1)
            => new Fixed2( ((uint)b1 << 1) | (uint)b0);

        [MethodImpl(Inline)]
        Fixed2(uint x0)
            => X0 = (byte)(x0 & Mask);

        [MethodImpl(Inline)]
        Fixed2(byte x0)
            => X0 = (byte)((uint)x0 & Mask);

        [MethodImpl(Inline)]
        public static explicit operator Fixed2(byte x)
            => new Fixed2(x);

        [MethodImpl(Inline)]
        public static implicit operator byte(Fixed2 x)
            => x.X0;
         
        [MethodImpl(Inline)]
        public bool Equals(Fixed2 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed2 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}