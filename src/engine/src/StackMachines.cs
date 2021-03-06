//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct StackMachines
    {
        [MethodImpl(Inline)]
        public static StackMachine create(uint capacity)
            => new StackMachine(capacity);
    }
}