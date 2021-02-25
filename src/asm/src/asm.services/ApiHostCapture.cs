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

        public ApiHostCaptureSet Capture(Type host)
        {
            var asmpath = Db.AppLog($"{host.Name}", FileExtensions.Asm);
            return Capture(host, asmpath);
        }

        public ApiHostCaptureSet Capture(Type host, FS.FilePath dst)
        {
            var catalog = ApiRuntime.catalog(Wf, host);
            using var service = Z0.Capture.quick(Wf, Asm);
            var blocks = service.CaptureHost(catalog);
            var count = blocks.Length;
            var decoded = AsmServices.decode(Asm, catalog,blocks);
            Emit(decoded, dst);
            return decoded;
        }

        void Emit(ApiHostCaptureSet src, FS.FilePath dst)
        {
            const string HeaderFormatPattern = "; BaseAddress:{0} | EndAddress:{1} | RangeSize:{2} | ExtractSize:{3} | ParsedSize:{4}";
            var buffer = text.buffer();
            var flow = Wf.EmittingFile(dst);
            var header = string.Format(HeaderFormatPattern, src.StartAddress, src.EndAddress, src.Range.Size, src.ExtractSize, src.ParsedSize);
            var emitted = 0;
            var routines = src.Routines.Edit;
            var count = routines.Length;
            var formatter = Asm.Formatter;
            using var writer = dst.Writer();
            writer.WriteLine(header);
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
        }
    }
}