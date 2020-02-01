//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static zfunc;

    public struct Fixed16 : IFixed<Fixed16,N16>, IEquatable<Fixed16>
    {
        public const int BitWidth = 16;

        internal ushort X0;

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
        internal Fixed16(ushort x)
            => X0 = x;

        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public bool Equals(Fixed16 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed16 x && Equals(x);

        public override string ToString() 
            => X0.ToString();
    }
}