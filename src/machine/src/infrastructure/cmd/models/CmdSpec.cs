//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cmd
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdSpec
    {
        public readonly StringRef Name;

        public readonly CmdFlag[] Flags;

        public readonly CmdOption[] Options;

        [MethodImpl(Inline)]
        public CmdSpec(string name, CmdFlag[] flags, CmdOption[] options)
        {
            Name = name;
            Flags = flags;
            Options = options;
        }    
    }
}