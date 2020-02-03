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


    public struct Fixed32 : IFixed<Fixed32,N32>, IEquatable<Fixed32>
    {
        public const int BitWidth = 32;        

        internal uint X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(uint x0)
            => new Fixed32(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(int x0)
            => new Fixed32((uint)x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(float x0)
            => new Fixed32(BitConvert.ToUInt32(x0));

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
        internal Fixed32(uint x0)
            => X0 = x0;

        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public bool Equals(Fixed32 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed32 x && Equals(x);


        public override string ToString() 
            => X0.ToString();
    }


}