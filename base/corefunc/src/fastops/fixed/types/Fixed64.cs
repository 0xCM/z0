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


    public struct Fixed64 : IFixed<Fixed64,N64>, IEquatable<Fixed64>
    {
        public const int BitWidth = 64;        

        internal ulong X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(int x0)
            => new Fixed64((ulong)(long)x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(long x0)
            => new Fixed64((ulong)x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(ulong x0)
            => new Fixed64(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(double x0)
            => new Fixed64(BitConvert.ToUInt64(x0));

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed64 x)
            => (sbyte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed64 x)
            => (byte)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator short(Fixed64 x)
            => (short)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed64 x)
            => (ushort)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed64 x)
            => (uint)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed64 x)
            => (int)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed64 x)
            => (long)x.X0;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed64 x)
            => x.X0;

        [MethodImpl(Inline)]
        internal Fixed64(ulong x0)
            => X0 = x0;
        
        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public bool Equals(Fixed64 src)
            => X0 == src.X0;
        
        public override int GetHashCode()
            => X0.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed64 x && Equals(x);

        public override string ToString() 
            => X0.ToString();
    }


}