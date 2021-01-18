//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdInfo
    {
        public CmdId Id {get;}

        public Type Definition {get;}

        public CmdFlagSpecs Flags {get;}

        public CmdOptionSpecs Options {get;}
    }

}