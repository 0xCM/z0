//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitHexIndex : CmdReactor<EmitHexIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitHexIndexCmd cmd)
            => react(Wf,cmd);

        [Op]
        static FS.FilePath react(IWfShell wf, EmitHexIndexCmd cmd)
        {
            var dst = wf.Db().IndexTable("apihex.index");
            var descriptors = ApiArchives.BlockDescriptors(wf);
            var count = ApiArchives.emit(descriptors, dst);
            wf.EmittedTable<ApiCodeDescriptor>(count, dst);
            return dst;
        }
    }
}