//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    public readonly struct CallerTarget
    {
        public static CallerTarget Define(OpUri caller, MemoryRange target)
            => new CallerTarget(caller, target);
        
        CallerTarget(OpUri caller, MemoryRange target)
        {
            this.Caller = caller;
            this.Target = target;
        }
        public readonly OpUri Caller;

        public readonly MemoryRange Target;
    }

    
}