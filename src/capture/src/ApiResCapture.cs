//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static memory;
    using static Part;

    public sealed class ApiResCapture : AsmWfService<ApiResCapture>
    {
        AsmRoutineDecoder Decoder;

       IAsmRoutineFormatter Formatter;

        protected override void OnContextCreated()
        {
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
        }

        public Index<CapturedApiRes> CaptureApiRes(FS.FilePath src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var res = Assembly.LoadFrom(src.Name);
            var accessors = Resources.accessors(res).View;
            var captured = CaptureAccessors(accessors, dst);
            Wf.EmittedFile(flow, captured.Count);
            return captured;
        }

        public Index<ApiRes> Load(FS.FilePath src)
        {
            var flow = Wf.Running(src.ToUri());
            var res = Assembly.LoadFrom(src.Name);
            var accessors = Resources.accessors(res).View;
            var count = accessors.Length;
            var captured = Load(accessors);
            Wf.Ran(flow,captured.Count);
            return captured;
        }

        public Index<ApiCaptureBlock> ReadBlocks(ReadOnlySpan<ApiResAccessor> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiCaptureBlock>(count);
            var blocks = span(buffer);
            var captured = alloc<CapturedApiRes>(count);
            using var quick = Wf.CaptureQuick();
            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member);
                seek(blocks, i) = code;
            }
            return buffer;
        }

        public Index<CapturedApiRes> CaptureAccessors(ReadOnlySpan<ApiResAccessor> src, FS.FilePath dst)
        {
            var count = src.Length;
            var codes = span(alloc<ApiCaptureBlock>(count));
            var captured = alloc<CapturedApiRes>(count);
            var target = span(captured);

            using var writer = dst.Writer();
            using var quick = Wf.CaptureQuick();

            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    var decoded = DecodeRoutine(data).ValueOrDefault(AsmRoutineCode.Empty);
                    var formatted = Formatter.Format(decoded.Routine);
                    seek(target, i) = new CapturedApiRes(accessor.Host, accessor, decoded);
                    writer.Write(formatted);
                }
            }

            return captured;
        }

        public Index<ApiRes> Load(ReadOnlySpan<ApiResAccessor> src)
        {
            const ulong Cut = 0x55005500550;
            var count = src.Length;
            var codes = span(alloc<ApiCaptureBlock>(count));
            var captured = alloc<ApiRes>(count);
            var target = span(captured);
            using var quick = Wf.CaptureQuick();
            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    var routine = DecodeRoutine(data).ValueOrDefault(AsmRoutineCode.Empty);
                    var movements = moves(routine.Routine);
                    var movecount = movements.Length;
                    for(var j=0u; j<movecount; j++)
                    {
                        ref readonly var move = ref skip(movements,j);
                        if(move.Source < Cut)
                        {
                            var capture = new CapturedApiRes(accessor.Host, accessor, routine);
                            seek(target, i) = new ApiRes(accessor, move.Source.ToAddress(), 10);
                            break;
                        }
                    }
                }
            }

            return captured;
        }

        public void Emit(ReadOnlySpan<CapturedApiRes> src, FS.FilePath dst)
        {
            const ulong Cut = 0x55005500550;
            const string Sep = RP.SpacePipe;
            const string StartMsg = "Emitting captured resource disassembly";
            const string Col0 = "Addresses";
            const string Col1 = "Accessor";
            const ushort Col0Width = 16;

            var capcount = src.Length;
            using var writer = dst.Writer();
            writer.WriteLine(text.concat(Col0.PadRight(Col0Width), Sep, Col1));

            for(var i=0u; i<capcount; i++)
            {
                ref readonly var captured = ref skip(src, i);
                var code = captured.Code;
                var host = captured.ApiHost;
                var accessor = captured.Accessor;
                var uri = ApiUri.hex(host, accessor.Member.Name, code.Code.MemberId);
                var movements = moves(code.Routine);
                var movecount = movements.Length;
                for(var j=0u; j<movecount; j++)
                {
                    ref readonly var move = ref skip(movements,j);
                    if(move.Source < Cut)
                        writer.WriteLine(text.concat(move.Source.ToAddress().Format().PadRight(Col0Width), Sep, uri));
                }
            }
        }

        Option<AsmRoutineCode> DecodeRoutine(ApiCaptureBlock capture)
        {
            var decoded = Decoder.Decode(capture);
            if(decoded)
            {
                var asm = Formatter.Format(decoded.Value);
                return new AsmRoutineCode(decoded.Value, capture, asm);
            }
            else
                return root.none<AsmRoutineCode>();
        }

        static ReadOnlySpan<Arrow<Imm64,IceRegister>> moves(in AsmRoutine src, int capacity = 10)
        {
            var hander = new AsmMovHandler(capacity);
            var fx = src.Instructions.View;
            var count = fx.Length;
            for(var i=0u; i<count; i++)
                hander.Handle(skip(fx, i).Instruction);
            return hander.Collected;
        }
    }
}