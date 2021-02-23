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

        protected override void OnInit()
        {
            base.OnInit();
            Asm = AsmServices.context(Wf);
        }

        public ApiHostCaptureSet EmitCaptureSet(Type host)
        {
            var asmpath = Db.AppLog($"{host.Name}", FileExtensions.Asm);
            return EmitCaptureSet(host, asmpath);
        }

        public ApiHostCaptureSet EmitCaptureSet(Type host, FS.FilePath dst)
        {
            const string HeaderFormatPattern = "; BaseAddress:{0} | EndAddress:{1} | RangeSize:{2} | ExtractSize:{3} | ParsedSize:{4}";
            var catalog = ApiCatalogs.HostCatalog(Wf, host);
            var blocks = CaptureHost(catalog);
            var count = blocks.Length;
            var set = Capture.set(Asm, catalog,blocks);
            var buffer = text.buffer();
            var flow = Wf.EmittingFile(dst);
            var header = string.Format(HeaderFormatPattern, set.StartAddress, set.EndAddress, set.Range.Size, set.ExtractSize, set.ParsedSize);
            using var writer = dst.Writer();
            writer.WriteLine(header);
            var emitted = 0;
            var routines = set.Routines.Edit;
            var formatter = Asm.Formatter;
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(routines,i);
                if(routine.IsNonEmpty)
                {
                    formatter.Format(routine, buffer);
                    writer.Write(buffer.Emit());
                    emitted++;
                }
            }

            Wf.EmittedFile(flow, emitted);
            return set;
        }

        public ApiCaptureBlocks CaptureHost(in ApiHostCatalog src)
        {
            using var service = Capture.quick(Wf,Asm);
            return service.CaptureHost(src);
        }
    }
}