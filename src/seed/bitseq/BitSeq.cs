//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using g = BitSeqG;
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
    public readonly struct BitSeq
    {
        [Op]
        public static uint4 max(W4 w)
            => g.max<uint4,byte>();

        [Op]
        public static uint6 max(W6 w)
            => g.max<uint6,byte>();

        [Op]
        public static uint7 max(W7 w)
            => g.max<uint7,byte>();

        [Op]
        public static uint4 inc(uint4 src)
            => g.inc(src);
            
        [Op]
        public static uint6 inc(uint6 src)
            => g.inc(src);
    }
    
    public partial class BitSeqG
    {
        
    }    
}