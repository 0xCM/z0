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

    public readonly struct CmdHandler : ICmdExec<CmdHandler>
    {
        public CmdId Id {get;}

        public ClrArtifactKey Host {get;}

        readonly Func<CmdSpec,CmdResult> Fx;

        [MethodImpl(Inline)]
        public CmdHandler(CmdId id, ClrArtifactKey host, Func<CmdSpec,CmdResult> fx)
        {
            Id = id;
            Host = host;
            Fx = fx;
        }

        [MethodImpl(Inline)]
        public CmdResult Exec(CmdSpec cmd)
            => Fx(cmd);
    }
}