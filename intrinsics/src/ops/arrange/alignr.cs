//-----------------------------------------------------------------------------
// Copyy   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;
    using static aux;

    partial class dinx
    {        
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, VAlignR offset)
            => AlignRight(x, y, (byte)offset);

        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, VAlignR offset)
            => AlignRight(x, y, (byte)offset);

        [MethodImpl(Inline)]
        public static Vector128<byte> valignr<N>(Vector128<byte> x, Vector128<byte> y, N n = default)
            where N : unmanaged, ITypeNat
                => valignr_n1(x,y,n);

        [MethodImpl(Inline)]
        public static Vector256<byte> valignr<N>(Vector256<byte> x, Vector256<byte> y, N n = default)
            where N : unmanaged, ITypeNat
                => valignr_n1(x,y,n);
 
    }

    public enum VAlignR : byte
    {
        R1 = 1,

        R2 = 2,

        R3 = 3,

        R4 = 4,

        R5 = 5,

        R6 = 6,

        R7 = 7,

        R8 = 8,

        R9 = 9,

        R10 = 10,

        R11 = 11,

        R12 = 12,

        R13 = 13,

        R14 = 14,

        R15 = 15,

        R16 = 16

    }

}