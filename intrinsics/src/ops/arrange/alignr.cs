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

    partial class dinx
    {        

        [MethodImpl(Inline)]
        public static Vector128<ulong> valignr(Vector128<ulong> x, Vector128<ulong> y, byte offset)
            => AlignRight(x, y, offset);

        [MethodImpl(Inline)]
        public static Vector256<ulong> valignr(Vector256<ulong> x, Vector256<ulong> y, byte offset)
            => AlignRight(x, y, offset);


        [MethodImpl(Inline)]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, byte offset)
            => AlignRight(x, y, offset);


        [MethodImpl(Inline)]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, byte offset)
            => AlignRight(x, y, offset);

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