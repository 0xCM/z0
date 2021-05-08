//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SwitchCase
    {
        public uint Index {get;}

        public Value Match {get;}

        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public SwitchCase(uint group, Name name, Value test)
        {
            Index = group;
            Name = name;
            Match = test;
        }
    }
}