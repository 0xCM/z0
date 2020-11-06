//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Konst;
    using static ApiDataModel;

    public sealed class EmitHexIndex : CmdHost<EmitHexIndex, EmitHexIndexCmd>
    {
        protected override CmdResult Execute(IWfShell wf, in EmitHexIndexCmd spec)
            => exec(wf,spec);

        [CmdWorker]
        public static CmdResult exec(IWfShell wf, EmitHexIndexCmd cmd)
        {
            var dst = wf.Db().Table("apihex.index");
            var descriptors = ApiCode.BlockDescriptors(wf);
            var count= ApiCode.emit(descriptors, dst);
            wf.EmittedTable<CodeBlockDescriptor>(count, dst);
            return Win();
        }
    }
}