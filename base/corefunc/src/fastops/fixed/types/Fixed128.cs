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


    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed128 : IFixed<Fixed128,N128>, IEquatable<Fixed128>
    {
        internal ulong X0;

        ulong X1;       

        public const int BitWidth = 128;        

        [MethodImpl(Inline)]
        public static implicit operator Fixed128((ulong x0, ulong x1) x)
            => new Fixed128(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in Pair<ulong> x)
            => new Fixed128(x.A,x.B);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<byte> x)
        {
            var dst = Fixed.alloc(n128);
            Fixed.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ushort> x)
        {
            var dst = Fixed.alloc(n128);
            Fixed.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<uint> x)
        {
            var dst = Fixed.alloc(n128);
            Fixed.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ulong> x)
        {
            var dst = Fixed.alloc(n128);
            Fixed.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        internal Fixed128(ulong x0, ulong x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }

        [MethodImpl(Inline)]
        public bool Equals(Fixed128 src)
            => X0 == src.X0 && X1 == src.X1;
        
        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed128 x && Equals(x);

        public override string ToString() 
            => array(X0,X1).FormatList();
    }
}