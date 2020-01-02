//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static As;
    using static HexConst;

    using static zfunc;
 
    /// <summary>
    /// Defines an 14x16 bitmatrix
    /// </summary>
    public struct BitMatrix4x16
    {
        internal ulong data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitMatrix4x16 A)
            => A.data;

        [MethodImpl(Inline)]
        public static implicit operator BitMatrix4x16(ulong src)
            => new BitMatrix4x16(src);

        [MethodImpl(Inline)]
        internal BitMatrix4x16(ulong data)
            => this.data = data;        
    }

    partial class BitMatrix
    {

        [MethodImpl(Inline)]
        public static BitMatrix4x16 define(N4 m, N16 n, ulong data)
            => data;
    }

    public static class BitMatrix4x16X
    {
        public static BitString ToBitString(this BitMatrix4x16 src)
            => src.data.ToBitString();


    }
}