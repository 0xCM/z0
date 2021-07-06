//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct SwitchCases<T>
            where T : unmanaged
        {
            readonly Index<T> Branches;

            readonly Index<string> Targets;

            [MethodImpl(Inline)]
            public SwitchCases(Index<T> branches, Index<string> targets)
            {
                Branches = branches;
                Targets = targets;
                Require.invariant(Branches.Length == Targets.Length, () => "Branch/Target lenths must match");
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Branches.Count;
            }

            public Paired<T,string> this[uint index]
            {
                [MethodImpl(Inline)]
                get => (Branches[index],Targets[index]);
            }
        }
    }
}