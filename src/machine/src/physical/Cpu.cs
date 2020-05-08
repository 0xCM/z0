//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Threading;
    using System.Threading.Tasks;
    
    using static Seed;

    public partial class Cpu
    {
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

        
        

        public class Core
        {
            
        }

    }
}