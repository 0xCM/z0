//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    partial struct ApiCode
    {
        public static void emit(IWfShell wf, ReadOnlySpan<ApiCodeDescriptor> src)
        {
            var dst = wf.Db().IndexTable("apihex.index");
            var count = emit(src, dst);
            wf.EmittedTable<ApiCodeDescriptor>(count, dst);
        }

        public static Outcome<FS.FilePath> emit(IWfShell wf)
        {
            try
            {
                var svc = ApiIndex.service(wf);
                var api = svc.CreateIndex();
                var path = wf.Db().IndexFile(ApiHexIndexRow.TableId);
                emit(wf, api, path);
                return path;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        public static Outcome emit(IWfShell wf, ApiCodeBlockIndex src, FS.FilePath dst)
        {
            var svc = ApiIndex.service(wf);
            Array.Sort(src.CodeBlocks.Storage);
            var blocks = src.CodeBlocks.View;
            var count = blocks.Length;
            var buffer = sys.alloc<ApiHexIndexRow>(count);
            var target = span(buffer);
            using var emitter = Records.emitter<ApiHexIndexRow>(sys.array<byte>(10, 16, 20, 20, 20, 120), dst);
            emitter.EmitHeader();
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                ref var record = ref seek(target, i);
                record.Seqence = i;
                record.Address = block.BaseAddress;
                record.Component = block.OpUri.Part.Format();
                record.HostName = block.OpUri.Host.Name;
                record.MethodName = block.OpId.Name;
                record.Uri = block.Uri;
                emitter.Emit(record);
            }
            return true;
        }

        [Op]
        public static uint emit(ReadOnlySpan<ApiCodeDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
            return count;
        }
    }
}