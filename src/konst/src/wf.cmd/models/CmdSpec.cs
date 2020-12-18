//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct CmdSpec : ICmdSpec, IDataType<CmdSpec>
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
            => Cmd.format(this);

        public override string ToString()
            => Format();

        public static CmdSpec Empty
        {
            [MethodImpl(Inline)]
            get => new CmdSpec(CmdId.Empty);
        }
    }
}