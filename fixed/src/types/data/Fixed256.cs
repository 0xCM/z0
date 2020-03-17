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

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    [Segmented(FixedWidth.W256,false,FixedWidth.NumericWidths)]
    public struct Fixed256  : IFixed<Fixed256>, IEquatable<Fixed256>
    {
        public const int BitWidth = 256;        

        Fixed128 X0;

        Fixed128 X1;

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        Fixed256(Fixed128 x0, Fixed128 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<byte> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<ushort> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<uint> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<ulong> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Fixed256 x)
            => x.ToVector<byte>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(Fixed256 x)
            => x.ToVector<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(Fixed256 x)
            => x.ToVector<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(Fixed256 x)
            => x.ToVector<ulong>();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256((Fixed128 x0, Fixed128 x1) x)
            => new Fixed256(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(in Pair<Fixed128> x)
            => new Fixed256(x.A,x.B);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(in ConstPair<Fixed128> x)
            => new Fixed256(x.A,x.B);

        [MethodImpl(Inline)]
        public bool Equals(Fixed256 src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);
        
        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed256 x && Equals(x);

        public override string ToString() 
            => array(X0,X1).FormatDataList();
    }

}