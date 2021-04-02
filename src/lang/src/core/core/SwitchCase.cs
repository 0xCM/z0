//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SwitchCase
    {
        public uint Group {get;}

        public Identifier Name {get;}

        public Value Match {get;}

        public SwitchCase(uint group, Name name, Value test)
        {
            Group = group;
            Name = name;
            Match = test;
        }
    }
}