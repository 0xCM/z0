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

    partial class MicroExpression
    {    
        [Closures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x2<T>(Branch8 decision, T payload)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, payload),
                    Branch8.Case2 => target(decision, payload),
                    _ => target(Branch8.None, payload),
                };

        [Closures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x3<T>(Branch8 decision, T payload)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, payload),
                    Branch8.Case2 => target(decision, payload),
                    Branch8.Case3 => target(decision, payload),
                    _ => target(Branch8.None, payload),
                };

        [Closures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x4<T>(Branch8 decision, T payload)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, payload),
                    Branch8.Case2 => target(decision, payload),
                    Branch8.Case3 => target(decision, payload),
                    Branch8.Case4 => target(decision, payload),
                    _ => target(Branch8.None, payload),
                };

        [Closures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x5<T>(Branch8 decision, T payload)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, payload),
                    Branch8.Case2 => target(decision, payload),
                    Branch8.Case3 => target(decision, payload),
                    Branch8.Case4 => target(decision, payload),
                    Branch8.Case5 => target(decision, payload),
                    _ => target(Branch8.None, payload),
                };

        [Closures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x6<T>(Branch8 decision, T payload)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, payload),
                    Branch8.Case2 => target(decision, payload),
                    Branch8.Case3 => target(decision, payload),
                    Branch8.Case4 => target(decision, payload),
                    Branch8.Case5 => target(decision, payload),
                    Branch8.Case6 => target(decision, payload),
                    _ => target(Branch8.None, payload),
                };

    }

}