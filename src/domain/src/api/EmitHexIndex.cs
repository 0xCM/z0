//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public sealed class EmitHexIndex : CmdHost<EmitHexIndex, EmitHexIndexCmd>
    {
        protected override CmdResult Execute(IWfShell wf, in EmitHexIndexCmd spec)
            => exec(wf,spec);

        public static CmdResult exec(IWfShell wf, EmitHexIndexCmd cmd)
        {
            var dst = wf.Db().Table("apihex.index");
            var descriptors = ApiArchives.BlockDescriptors(wf);
            var count= ApiArchives.emit(descriptors, dst);
            wf.EmittedTable<ApiCodeDescriptor>(count, dst);
            return Win();
        }
    }
}