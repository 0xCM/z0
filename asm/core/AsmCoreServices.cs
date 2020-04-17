//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.IO;

    using Svc = Z0.Asm;
    
    using static Seed;

    public static class AsmCoreServices
    {                       
        [MethodImpl(Inline)]
        public static IExtractParser ExtractParser(this IAsmContext context, byte[] buffer)
            => Svc.ExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IExtractParser ExtractParser(this IAsmContext context, int? bufferlen = null)
            => Svc.ExtractParser.Create(context, bufferlen);

        [MethodImpl(Inline)]
        public static IAsmFunctionBuilder FunctionBuilder(this IContext context)
            => AsmFunctionBuilder.Create(context);        

        [MethodImpl(Inline)]
        public static IHostCodeExtractor HostExtractor(this IContext context, int? bufferlen = null)
            => Svc.HostCodeExtractor.Create(context, bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public static IMemoryExtractor MemoryExtractor(this IContext context, byte[] buffer)
            => Svc.MemoryExtractor.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IMemoryExtractParser MemoryExtractParser(this IContext context, byte[] buffer)
            => Svc.MemoryExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IMemberExtractReader MemberExtractReader(this IContext context, IApiSet api)
            => Z0.MemberExtractReader.Create(context.MemberLocator(), api);

        [MethodImpl(Inline)]
        public static ByteParser<EncodingPatternKind> PatternParser(this IContext context, byte[] buffer)
            => ByteParser<EncodingPatternKind>.Create(context, EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IContext context)
            => CaptureService.Create(context);

        /// <summary>
        /// Creates an asm buffer set, which is considered an asm service but cannot be contracted since it is a ref struct
        /// </summary>
        /// <param name="context">The context assubmed by the buffers</param>
        /// <param name="sink">The target to which capture events are routed</param>
        /// <param name="size">The (uniform) buffer length</param>
        [MethodImpl(Inline)]
        public static BufferSeq Buffers(this IContext context, int size, int count)
            => BufferSeq.alloc(size,count);

        /// <summary>
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        [MethodImpl(Inline)]
        public static IAsmInstructionFlow InstructionFlow(this IContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);

        public static CaptureExchange ExtractExchange(this IContext context, int? size = null)
        {
            const int DefaultBufferLen = 1024*8;
            var control = ExtractControl.New(context);
            var cBuffer = new byte[size ?? DefaultBufferLen];
            var sBuffer = new byte[size ?? DefaultBufferLen];
            return CaptureExchange.New(control, cBuffer, sBuffer);
        }        
        
        [MethodImpl(Inline)]
        public static IHostAsmArchiver ImmFunctionArchive(this IContext context, ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => HostAsmArchiver.ImmArchive(context, host, formatter, dst);

        [MethodImpl(Inline)]
        public static IImmSpecializer ImmSpecializer(this IContext context, IAsmFunctionDecoder decoder)
            => Svc.ImmSpecializer.Create(context, decoder);

        /// <summary>
        /// Instantiates a basic capture service that supports the extract/parse/decode workflow
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IHostCaptureService HostCaptureService(this IAsmContext context, FolderName area = null, FolderName subject = null)
            => Svc.HostCaptureService.Create(context, area, subject);

        public static void WriteDiagnostic(this StreamWriter writer, in ApiMemberCapture src)
        {
            var data = src.Parsed;
            var dst = text.build();
			dst.AppendLine($"; label   : {src.OpSig}");
			dst.AppendLine($"; location: {src.AddressRange.Format()}, length: {src.AddressRange.Length} bytes");
            var lines = data.Bytes.FormatHexLines(null);
            dst.Append(lines.Concat(Chars.Eol));
            dst.AppendLine(new string('_',80));
            writer.Write(dst.ToString());
        }

        public static void WriteHexLine(this IBitArchiveWriter writer, in ApiMemberCapture src, int? idpad = null)
            => writer.WriteCode(EncodedHexLine.Define(src.OpId, src.Extracted.Bytes),idpad); 
    }
}