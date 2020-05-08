//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class AsmExpr
    {
        public byte switch8x2(Branch8 decision)
                => decision switch {
                    Branch8.Case1 => 19,
                    Branch8.Case2 => 32,
                    _ => 0,
                };

        public byte switch8x6(Branch8 decision)
                => decision switch {
                    Branch8.Case1 => 19,
                    Branch8.Case2 => 32,
                    Branch8.Case3 => 11,
                    Branch8.Case4 => 8,
                    Branch8.Case5 => 17,
                    Branch8.Case6 => 1,
                    _ => 0,
                };


        [Op]
        public uint switch32x3(Branch32 decision)
                => decision switch {
                    Branch32.Case1 => 333,
                    Branch32.Case2 => 344,
                    Branch32.Case3 => 898,
                    _ => 0,
                };

        [Op]
        public uint switch32x4(Branch32 decision)
                => decision switch {
                    Branch32.Case1 => 333,
                    Branch32.Case2 => 344,
                    Branch32.Case3 => 898,
                    Branch32.Case4 => 511,
                    _ => 0,
                };

        [Op]
        public ulong switch64x4(Branch64 decision)
                => decision switch {
                    Branch64.Case1 => 333,
                    Branch64.Case2 => 344,
                    Branch64.Case3 => 898,
                    Branch64.Case4 => 511,
                    _ => 0,
                };

    }
}