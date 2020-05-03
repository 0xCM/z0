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
        const NumericKind SwitchClosures = Numeric32u | Numeric32i;


        [Closures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x2_d<T>(Branch8 decision, Func<Branch8,T> factory)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, factory(decision)),
                    Branch8.Case2 => target(decision, factory(decision)),
                    _ => target(Branch8.None, default(T)),
                };

        [NumericClosures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x3_d<T>(Branch8 decision, Func<Branch8,T> factory)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, factory(decision)),
                    Branch8.Case2 => target(decision, factory(decision)),
                    Branch8.Case3 => target(decision, factory(decision)),
                    _ => target(Branch8.None, default(T)),
                };

        [NumericClosures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x4_d<T>(Branch8 decision, Func<Branch8,T> factory)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, factory(decision)),
                    Branch8.Case2 => target(decision, factory(decision)),
                    Branch8.Case3 => target(decision, factory(decision)),
                    Branch8.Case4 => target(decision, factory(decision)),
                    _ => target(Branch8.None, default(T)),
                };

        [NumericClosures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x5_d<T>(Branch8 decision, Func<Branch8,T> factory)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, factory(decision)),
                    Branch8.Case2 => target(decision, factory(decision)),
                    Branch8.Case3 => target(decision, factory(decision)),
                    Branch8.Case4 => target(decision, factory(decision)),
                    Branch8.Case5 => target(decision, factory(decision)),
                    _ => target(Branch8.None, default(T)),
                };

        [NumericClosures(SwitchClosures)]
        public BranchTarget<Branch8,T> switch8x6_d<T>(Branch8 decision, Func<Branch8,T> factory)
            where T : unmanaged
                => decision switch {
                    Branch8.Case1 => target(decision, factory(decision)),
                    Branch8.Case2 => target(decision, factory(decision)),
                    Branch8.Case3 => target(decision, factory(decision)),
                    Branch8.Case4 => target(decision, factory(decision)),
                    Branch8.Case5 => target(decision, factory(decision)),
                    Branch8.Case6 => target(decision, factory(decision)),
                    _ => target(Branch8.None, default(T)),
                };

    }
}