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

    sealed class ApiResCapture : AsmWfService<ApiResCapture>, IApiResCapture
    {
        public Index<CapturedApiRes> CaptureApiRes(FS.FilePath src, FS.FolderPath dst)
        {
            var resdll = Assembly.LoadFrom(src.Name);
            var indices = Resources.apires(resdll).View;
            var count = indices.Length;
            var results = root.list<CapturedApiRes>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var index = ref skip(indices, i);
                var host = ApiHostUri.from(index.DeclaringType);
                var path = dst + ApiIdentity.file(host, FileExtensions.Asm);
                results.AddRange(CaptureAccessors(host, index.View, path));
            }

            return results.ToArray();
        }

        public Index<CapturedApiRes> CaptureApiRes(ApiHostUri host, FS.FilePath dst)
            => CaptureAccessors(host, Resources.accessors(Wf.Api.PartComponents), dst);

        public Index<CapturedApiRes> CaptureAccessors(ApiHostUri host, ReadOnlySpan<ApiResAccessor> src, FS.FilePath dst)
        {
            var count = src.Length;
            var codes = span(alloc<ApiCaptureBlock>(count));
            var captured = alloc<CapturedApiRes>(count);
            var target = span(captured);

            using var writer = dst.Writer();
            using var quick = AsmServices.CaptureQuick(Wf, Asm);

            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member).ValueOrDefault(ApiCaptureBlock.Empty);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    seek(target, i) = new CapturedApiRes(host, accessor, DecodeRoutine(data).ValueOrDefault(AsmRoutineCode.Empty));
                    Save(data, writer);
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
            var formatted = Asm.Formatter.FormatFunction(asm);
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