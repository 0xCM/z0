//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    sealed class JitApi : CmdReactor<JitApiCmd>
    {
        protected override CmdResult Run(JitApiCmd cmd)
            => cmd.Success(ApiJit.service(Wf).JitApi(Db.IndexFile(ApiAddressRecord.TableId)));
    }

    internal static partial class XReact
    {
        public static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmdSpec<C>
                => new CmdResult<C,P>(cmd,true,payload);
    }
}