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

    public readonly struct CmdResult
    {
        public CmdId Id {get;}

        public bool Succeeded {get;}

        //public WfEvent[] Events {get;}

        public BinaryCode Payload {get;}

        public static CmdResult Empty => default;
    }
}