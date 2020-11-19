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

    using api = Cmd;

    public struct CmdSpec : ICmdSpec, ITextual
    {
        public CmdId CmdId {get;}

        public CmdArgs Args {get;}

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdArg[] args)
        {
            CmdId = id;
            Args = args;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static CmdSpec Empty
        {
            [MethodImpl(Inline)]
            get => new CmdSpec(CmdId.Empty);
        }
    }
}