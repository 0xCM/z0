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
        public static implicit operator Fixed64(long x0)
            => new Fixed64((ulong)x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(ulong x0)
            => new Fixed64(x0);

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed64 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed64 x)
            => (long)x.X0;

        [MethodImpl(Inline)]
        internal Fixed64(ulong x0)
            => X0 = x0;
        
        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
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