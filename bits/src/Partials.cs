//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public static unsafe partial class BitPoints
    {
        [MethodImpl(Inline)]
        static ulong content(byte* pA)
            => *(ulong*)pA;

        [MethodImpl(Inline)]
        static ulong content(in byte rA)
            => *(ulong*)As.constptr(in rA);

        [MethodImpl(Inline)]
        static void content(ulong src, byte* pDst)
             => *((ulong*)pDst) = src;

        [MethodImpl(Inline)]
        static void content(ulong src, ref byte pDst)
             => *((ulong*)As.refptr(ref pDst)) = src;

    }

    public static partial class BitMatrix
    {

    }

    public static partial class Bits
    {
        
    }

    public static partial class gbits
    {

    }
    public static partial class BitsX
    {

    }

    /// <summary>
    /// Defines bitwise reference operations
    /// </summary>
    public static partial class BitRef
    {



    }

    /// <summary>
    /// Opcodes for scalar bit-level operations
    /// </summary>
    public static partial class bvoc
    {

    }


}