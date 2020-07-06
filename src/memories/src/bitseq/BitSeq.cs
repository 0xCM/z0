//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S4 = uint4;
    using S5 = uint5;

    [ApiHost]
    public partial class BitSeqD
    {
        public static byte reduce(N4 n, byte x)
            => (byte)(x % S4.Count);

        public static byte reduce(N5 n, byte x)
            => (byte)(x % S5.Count);
    }

    [ApiHost]
    public readonly partial struct BitSeq
    {

 
    }
}