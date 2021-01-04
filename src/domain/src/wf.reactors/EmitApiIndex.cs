//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;
    using System;

    sealed class EmitApiIndex : CmdReactor<EmitApiIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitApiIndexCmd cmd)
        {
            var svc = ApiIndex.service(Wf);
            var api = svc.CreateIndex();
            var path = Db.IndexFile(ApiHexIndexRow.TableId);
            ApiCode.emit(Wf, api, path);
            return path;

            // Array.Sort(api.CodeBlocks.Storage);
            // var blocks = api.CodeBlocks.View;
            // var count = blocks.Length;
            // var buffer = sys.alloc<ApiHexIndexRow>(count);
            // var target = span(buffer);
            // using var emitter = Records.emitter<ApiHexIndexRow>(array<byte>(10, 16, 20, 20, 20, 120), path);
            // emitter.EmitHeader();
            // for(var i=0u; i<count; i++)
            // {
            //     ref readonly var src = ref skip(blocks,i);
            //     ref var dst = ref seek(target, i);
            //     dst.Seqence = i;
            //     dst.Address = src.BaseAddress;
            //     dst.Component = src.OpUri.Part.Format();
            //     dst.HostName = src.OpUri.Host.Name;
            //     dst.MethodName = src.OpId.Name;
            //     dst.Uri = src.Uri;
            //     emitter.Emit(dst);
            // }
            // return path;
        }
    }
}