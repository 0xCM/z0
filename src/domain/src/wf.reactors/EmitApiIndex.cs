//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitApiIndex : CmdReactor<EmitApiIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitApiIndexCmd cmd)
            => ApiCode.emit(Wf);
        // {
        //     var svc = ApiIndex.service(Wf);
        //     var api = svc.CreateIndex();
        //     var path = Db.IndexFile(ApiHexIndexRow.TableId);
        //     ApiCode.emit(Wf, api, path);
        //     return path;
        // }
    }
}