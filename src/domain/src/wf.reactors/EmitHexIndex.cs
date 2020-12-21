//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;

    sealed class EmitHexIndex : CmdReactor<EmitHexIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitHexIndexCmd cmd)
        {
            var dst = Db.IndexTable("apihex.index");
            var archive = WfArchives.hex(Wf);
            var descriptors = ApiCode.descriptors(Wf);
            if(descriptors.Count != 0)
            {
                var count = ApiCode.emit(descriptors, dst);
                Wf.EmittedTable<ApiCodeDescriptor>(count, dst);
            }
            return dst;
        }
    }
}