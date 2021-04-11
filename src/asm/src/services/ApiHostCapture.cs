//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    sealed class ApiHostCapture : WfService<ApiHostCapture>, IApiHostCapture
    {
        IAsmContext Asm;

        ApiServices Api;

        ApiCatalogs Catalogs;

        protected override void OnInit()
        {
            base.OnInit();
            Asm = Wf.AsmContext();
            Api = Wf.ApiServices();
            Catalogs =  Wf.ApiCatalogs();
        }

        public ApiHostCaptureSet Capture(Type host)
        {
            var asmpath = Db.AppLog($"{host.Name}", FS.Asm);
            return Capture(host, asmpath);
        }

        public ApiHostCaptureSet Capture(Type host, FS.FilePath dst)
        {
            var catalog = Catalogs.HostCatalog(host);
            using var service = Wf.CaptureQuick(Asm);
            var blocks = service.CaptureHost(catalog);
            var count = blocks.Length;
            var decoded = Decode(catalog, blocks);
            Emit(decoded, dst);
            return decoded;
        }

        public ApiHostCaptureSet Decode(in ApiHostCatalog catalog, ApiCaptureBlocks blocks)
        {
            var count = blocks.Length;
            var set = new ApiHostCaptureSet(catalog, blocks, alloc<AsmRoutine>(count));
            var blockview = set.Blocks.View;
            var routines = set.Routines.Edit;
            var decoder = Asm.RoutineDecoder;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blockview,i);
                if(decoder.Decode(block, out var routine))
                    seek(routines, i) = routine;
            }

            return set;
        }

        public void Emit(ApiHostCaptureSet src, FS.FilePath dst)
        {
            const string HeaderFormatPattern = "; BaseAddress:{0} | EndAddress:{1} | RangeSize:{2} | ExtractSize:{3} | ParsedSize:{4}";
            var buffer = text.buffer();
            var flow = Wf.EmittingFile(dst);
            var header = string.Format(HeaderFormatPattern, src.StartAddress, src.EndAddress, src.Range.Size, src.ExtractSize, src.ParsedSize);
            var emitted = 0;
            var routines = src.Routines.Edit;
            var count = routines.Length;
            var formatter = Wf.AsmFormatter();
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(routines,i);
                if(routine.IsNonEmpty)
                {
                    formatter.Render(routine, buffer);
                    writer.Write(buffer.Emit());
                    emitted++;
                }
            }

            Wf.EmittedFile(flow, emitted);
        }
    }
}