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

    using static Fixed;

    [StructLayout(LayoutKind.Sequential)]
    [Fixed(FixedWidth.W128,false,FixedWidth.NumericWidths)]
    public struct Fixed128 : IFixed<Fixed128>, IEquatable<Fixed128>
    {
        ulong X0;

        ulong X1;       

        public int BitWidth  { [MethodImpl(Inline)] get => 128; }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        Fixed128(ulong x0, ulong x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128((ulong x0, ulong x1) x)
            => new Fixed128(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in Pair<ulong> x)
            => new Fixed128(x.Left,x.Right);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in ConstPair<ulong> x)
            => new Fixed128(x.Left,x.Right);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<byte> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ushort> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<uint> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ulong> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(Fixed128 x)
            => x.ToVector<byte>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(Fixed128 x)
            => x.ToVector<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(Fixed128 x)
            => x.ToVector<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(Fixed128 x)
            => x.ToVector<ulong>();
               
        [MethodImpl(Inline)]
        public bool Equals(Fixed128 src)
            => X0 == src.X0 && X1 == src.X1;
        
        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed128 x && Equals(x);

        public override string ToString() 
            => Arrays.from(X0,X1).FormatDataList();       
    }
}