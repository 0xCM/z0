//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SwitchCases<T>
        where T : unmanaged
    {
        readonly Index<T> Branches;

        readonly Index<Identifier> Targets;

        [MethodImpl(Inline)]
        public SwitchCases(Index<T> branches, Index<Identifier> targets)
        {
            Branches = branches;
            Targets = targets;
            root.require(Branches.Length == Targets.Length, () => "Branch/Target lenths must match");
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Branches.Count;
        }

        public Paired<T,Identifier> this[uint index]
        {
            [MethodImpl(Inline)]
            get => (Branches[index],Targets[index]);
        }
    }
}