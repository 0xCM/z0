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

    }
}