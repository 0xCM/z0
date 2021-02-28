//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using Z0.Asm;

    using static memory;
    using static Part;

    public sealed class ApiResCapture : AsmWfService<ApiResCapture>
    {
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

        public Index<CapturedApiRes> CaptureAccessors(ReadOnlySpan<ApiResAccessor> src, FS.FilePath dst)
        {
            var count = src.Length;
            var codes = span(alloc<ApiCaptureBlock>(count));
            var captured = alloc<CapturedApiRes>(count);
            var target = span(captured);

            using var writer = dst.Writer();
            using var quick = Wf.CaptureQuick(Asm);

            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member).ValueOrDefault(ApiCaptureBlock.Empty);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    var decoded = DecodeRoutine(data).ValueOrDefault(AsmRoutineCode.Empty);
                    var formatted = Asm.Formatter.Format(decoded.Routine);
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
            using var quick = Wf.CaptureQuick(Asm);
            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member).ValueOrDefault(ApiCaptureBlock.Empty);
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
                var uri = OpUri.hex(host, accessor.Member.Name, code.Code.MemberId);
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
            var decoded = Asm.RoutineDecoder.Decode(capture);
            if(decoded)
                return new AsmRoutineCode(decoded.Value, capture);
            else
                return root.none<AsmRoutineCode>();
        }

        void Save(ApiCaptureBlock capture, StreamWriter dst)
        {
            var asm = Asm.RoutineDecoder.Decode(capture).Require();
            var formatted = Asm.Formatter.Format(asm);
            dst.Write(formatted);
        }

        static ReadOnlySpan<Link<Imm64,IceRegister>> moves(in AsmRoutine src, int capacity = 10)
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