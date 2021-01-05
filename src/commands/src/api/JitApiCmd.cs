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

    [Cmd(CmdName)]
    public struct JitApiCmd : ICmdSpec<JitApiCmd>
    {
        public const string CmdName = "jit-api";
    }

    sealed class JitApiReactor : CmdReactor<JitApiCmd>
    {
        protected override CmdResult Run(JitApiCmd cmd)
            => cmd.Success(ApiJit.service(Wf).JitApi(Db.IndexFile(ApiAddressRecord.TableId)));
    }

    partial class XCmd
    {
        [Op]
        public static JitApiCmd JitApiCmd(this CmdBuilder builder)
            => new JitApiCmd();

        internal static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmdSpec<C>
                => new CmdResult<C,P>(cmd,true,payload);
    }
}