//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        [MethodImpl(Inline)]
        public static CmdResult ok<T>(T spec)
            where T : ICmdSpec
                => new CmdResult(spec.CmdId, true);

        [MethodImpl(Inline)]
        public static CmdResult ok<C>(C spec, string msg)
            where C : ICmdSpec
                => new CmdResult(spec.CmdId, true, msg);

        [MethodImpl(Inline)]
        public static CmdResult<T> ok<C,T>(C spec, T payload, string msg = EmptyString)
            where C : ICmdSpec
                => new CmdResult<T>(spec.CmdId, true, payload, msg);
    }
}