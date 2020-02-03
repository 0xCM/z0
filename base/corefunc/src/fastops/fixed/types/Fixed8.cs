//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public struct Fixed8 : IFixed<Fixed8,N8>, IEquatable<Fixed8>
    {
        public const int BitWidth = 8;        

        internal byte X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(byte x0)
            => new Fixed8(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(sbyte x0)
            => new Fixed8((byte)x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(int x)
            => new Fixed8((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(uint x)
            => new Fixed8((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed8 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed8 x)
            => (byte)x.X0;

        [MethodImpl(Inline)]
        internal Fixed8(byte x0)
            => X0 = x0;

        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public bool Equals(Fixed8 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed8 x && Equals(x);
        
        public override string ToString() 
            => X0.ToString();
    }
}