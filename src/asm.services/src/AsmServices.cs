//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsmFxCheck;
    using static z;

    public readonly struct AsmServices : IAsmServices
    {
        public static IAsmServices Services => default(AsmServices);

        public static FS.FilePath emit(IWfShell wf, ApiHostUri uri, ReadOnlySpan<AsmRoutine> src, in AsmFormatConfig format)
        {
            var count = src.Length;
            if(count != 0)
            {
                var path = wf.Db().CapturedAsmFile(uri);
                using var writer = path.Writer();
                var buffer = Buffers.text();

                for(var i=0; i<count; i++)
                {
                    ref readonly var routine = ref skip(src,i);
                    AsmRender.format(routine, format, buffer);
                    writer.Write(buffer.Emit());
                }
                return path;
            }
            else
                return FS.FilePath.Empty;
        }

        [MethodImpl(Inline), Op]
        public static AsmRoutine routine(ApiCaptureBlock captured, AsmFxList src)
        {
            var code = new ApiCodeBlock(captured.OpUri, captured.Parsed);
            var sig = captured.Method.Metadata().Format();
            return new AsmRoutine(captured.MetaUri, captured.OpUri, sig, code, captured.TermCode, src);
        }

        [MethodImpl(Inline), Op]
        public static AsmRoutine routine(ApiMemberCode member, AsmInstructions asm)
        {
            var code = new ApiCodeBlock(member.OpUri, member.Encoded);
            var sig = member.Method.Metadata().Format();
            return new AsmRoutine(member.MetaUri, member.OpUri, sig, code, member.TermCode, new AsmFxList(asm, member.Encoded));
        }

        [MethodImpl(Inline), Op]
        public static AsmWriter writer(FS.FilePath dst)
            => new AsmWriter(dst, new AsmFormatter());

        [MethodImpl(Inline), Op]
        public static AsmWriter writer(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, new AsmFormatter(config));

        [MethodImpl(Inline), Op]
        public static AsmWriter writer(FS.FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst, formatter);

        [Op]
        public static AsmRoutine routine(ApiMetadataUri meta, OpUri uri, string sig, ApiBlockAsm src, bool check = false)
        {
            var count = src.InstructionCount;
            var info = new AsmFxSummary[count];
            var offset = 0u;
            var @base = src.BaseAddress;

            for(var i=0; i<count; i++)
            {
                var instruction = src[i];
                if(check)
                    CheckInstructionSize(instruction, offset, src);
                info[i] = asm.summarize(@base, instruction, src.Encoded.Code, instruction.FormattedInstruction, offset);
                offset += (uint)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            return new AsmRoutine(meta, uri, sig, src.Encoded, src.TermCode, asm.list(src.Decoded, src.Encoded.Code));
        }
    }
}