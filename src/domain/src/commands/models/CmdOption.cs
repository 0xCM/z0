//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdOption
    {
        public string Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public CmdOption(string name)
        {
            Name = name;
            Value = EmptyString;
        }
    }
}