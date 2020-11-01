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

    public struct CmdSpec
    {
        public CmdId Id {get;}

        public CmdArgs Options {get;}

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdArg[] options)
        {
            Id = id;
            Options = options;
        }
    }
}