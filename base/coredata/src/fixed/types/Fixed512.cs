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

    using static zfunc;

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed512  : IFixed<Fixed512,N512>
    {
        public const int BitWidth = 512;        

        [MethodImpl(Inline)]
        public static implicit operator Fixed512((Fixed256 x0, Fixed256 x1) x)
            => new Fixed512(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(in Pair<Fixed256> x)
            => new Fixed512(x.A,x.B);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(in ConstPair<Fixed256> x)
            => new Fixed512(x.A,x.B);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(Vector512<byte> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(Vector512<ushort> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(Vector512<uint> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(Vector512<ulong> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Vector512<byte>(Fixed512 x)
            => x.ToVector<byte>();

        [MethodImpl(Inline)]
        public static implicit operator Vector512<ushort>(Fixed512 x)
            => x.ToVector<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector512<uint>(Fixed512 x)
            => x.ToVector<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector512<ulong>(Fixed512 x)
            => x.ToVector<ulong>();

        [MethodImpl(Inline)]
        internal Fixed512(Fixed256 x0, Fixed256 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        internal Fixed256 X0;

        Fixed256 X1;
        
        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }
    }
}