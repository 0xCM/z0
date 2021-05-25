//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct StackState
    {
        public uint Input;

        public uint Output;

        public uint Index;

        public uint Capacity;

        [MethodImpl(Inline)]
        public StackState(uint capacity)
        {
            Capacity = capacity;
            Index = capacity;
            Input = capacity;
            Output = capacity;
        }
    }
}