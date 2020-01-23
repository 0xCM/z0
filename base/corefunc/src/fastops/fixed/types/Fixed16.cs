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
        public static implicit operator Fixed16(ushort x0)
            => new Fixed16(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(short x0)
            => new Fixed16((ushort)x0);

        [MethodImpl(Inline)]
        internal Fixed16(ushort x0)
            => X0 = x0;

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
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