//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    sealed class EmitHexIndex : CmdReactor<EmitHexIndex,EmitHexIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitHexIndexCmd cmd)
        {
            var dst = Db.Table("apihex.index");
            var parts = cmd.Parts.IsEmpty ? Wf.Api.PartIdentities : cmd.Parts.Storage;
            var descriptors = ApiArchives.BlockDescriptors(Wf, parts);
            var count= ApiArchives.emit(descriptors, dst);
            Wf.EmittedTable<ApiCodeDescriptor>(count, dst);
            return dst;
        }
    }
}