//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

/*
| Cmp         | Cmp_rm8_r8 | 64  | True | False   | 38 CE                     | 38 CE                     |             | 2           | reg           | DH            | reg           | CL            | reg           |               | reg           |               | reg           |               |                 |             |                 |             |                 |                 |                 |                 |                 |                 |                 |                 | None    
*/

    readonly struct CoreState
    {
        public static CoreState Alloc(uint g = 16, uint v = 32)
            => new CoreState(g,v);

        readonly Fixed64[] G;

        readonly Fixed512[] V;

        CoreState(uint g, uint v)
        {
            G = Control.alloc<Fixed64>(g);
            V = Control.alloc<Fixed512>(v);
        }
    }
}