//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class JitApi : CmdReactor<JitApiCmd>
    {
        protected override CmdResult Run(JitApiCmd cmd)
            => cmd.Success(ApiJit.service(Wf).JitApi(Db.IndexFile(ApiAddressRecord.TableId)));
    }

    internal static partial class XReact
    {
        public static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmd<C>
                => new CmdResult<C,P>(cmd,true,payload);
    }
}