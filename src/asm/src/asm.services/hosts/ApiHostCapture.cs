//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    sealed class ApiHostCapture : AsmWfService<ApiHostCapture>, IApiHostCapture
    {
        public ApiHostCaptureSet EmitCaptureSet(Type host)
        {
            const string HeaderFormatPattern = "; BaseAddress:{0} | EndAddress:{1} | RangeSize:{2} | ExtractSize:{3} | ParsedSize:{4}";
            var catalog = ApiCatalogs.host(Wf,host);
            var capture = AsmServices.alt(Wf,Asm);
            var blocks = capture.Capture(catalog);
            var count = blocks.Length;
            var set = new ApiHostCaptureSet(catalog, blocks, alloc<AsmRoutine>(count));
            var blockview = set.Blocks.View;
            var buffer = text.buffer();
            var asmpath = Db.AppLog($"{host.Name}", FileExtensions.Asm);
            var flow = Wf.EmittingFile(asmpath);
            var header = string.Format(HeaderFormatPattern, set.StartAddress, set.EndAddress, set.Range.Size, set.ExtractSize, set.ParsedSize);
            using var writer = asmpath.Writer();
            writer.WriteLine(header);
            var emitted = 0;
            var routines = set.Routines.Edit;
            var decoder = Asm.RoutineDecoder;
            var formatter = Asm.Formatter;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blockview,i);
                if(decoder.Decode(block, out var routine))
                {
                    seek(routines, i) = routine;
                    formatter.Format(routine, buffer);
                    writer.Write(buffer.Emit());
                    emitted++;
                }
            }
            Wf.EmittedFile(flow, $"{emitted} routines", asmpath);
            return set;
        }
    }
}