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
    public struct Fixed512  : IFixed<Fixed512>
    {
        public const int BitWidth = 512;        

        Fixed256 X0;

        Fixed256 X1;

        public int BitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        Fixed512(Fixed256 x0, Fixed256 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed512((Fixed256 x0, Fixed256 x1) x)
            => new Fixed512(x.x0,x.x1);

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

        public string Format() 
            => array(X0,X1).FormatList();

        [MethodImpl(Inline)]
        public bool Equals(Fixed512 src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);

        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed512 x && Equals(x);

        public override string ToString() 
            => Format();                      
    }
}