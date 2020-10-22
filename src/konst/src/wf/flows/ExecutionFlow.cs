//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ExecutionFlow
    {
        [MethodImpl(Inline)]
        public static ExecutionFlow create(ulong src)
            => new ExecutionFlow(src);

        public ulong Dispensed {get;}

        public ulong Reaction {get;}

        [MethodImpl(Inline)]
        ExecutionFlow(ulong dispensed)
        {
            Dispensed = dispensed;
            Reaction = 0;
        }

        [MethodImpl(Inline)]
        ExecutionFlow(ulong dispensed, ulong reaction)
        {
            Dispensed = dispensed;
            Reaction = reaction;
        }

        public Cell128 Data
        {
            [MethodImpl(Inline)]
            get => z.@as<ExecutionFlow,Cell128>(this);
        }

        [MethodImpl(Inline)]
        public ExecutionFlow Reacted(ulong reaction)
            => new ExecutionFlow(Dispensed, reaction);
    }
}