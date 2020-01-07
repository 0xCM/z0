//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public static class Pow2Log2    
    {                
        public static IEnumerable<Pair<int,byte>> Enumerate
            => typeof(Pow2Log2).LiteralValues<byte>();

        public const byte L2_T00 = 2*0 >> 1;

        public const byte L2_T01 = 2*1 >> 1;

        public const byte L2_T02 = 2*2 >> 1;

        public const byte L2_T03 = 2*3 >> 1;

        public const byte L2_T04 = 2*4 >> 1;

        public const byte L2_T05 = 2*5 >> 1;

        public const byte L2_T06 = 2*6 >> 1;

        public const byte L2_T07 = 2*7 >> 1;

        public const byte L2_T08 = 2*8 >> 1;

        public const byte L2_T09 = 2*9 >> 1;

        public const byte L2_T10 = 2*10 >> 1;

        public const byte L2_T11 = 2*11 >> 1;

        public const byte L2_T12 = 2*12 >> 1;
        
        public const byte L2_T13 = 2*13 >> 1;

        public const byte L2_T14 = 2*14 >> 1;

        public const byte L2_T15 = 2*15 >> 1;

        public const byte L2_T16 = 2*16 >> 1;

        public const byte L2_T17 = 2*17 >> 1;

        public const byte L2_T18 = 2*18 >> 1;


    }
}