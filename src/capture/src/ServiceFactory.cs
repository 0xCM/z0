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
        public static IAsmFunctionBuilder FunctionBuilder(this IContext context)
            => AsmFunctionBuilder.Create(context);        

        [MethodImpl(Inline)]
        public static IHostCodeExtractor HostExtractor(this IContext context, int? bufferlen = null)
            => HostCodeExtractor.Create(context, bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public static IMemoryExtractor MemoryExtractor(this IContext context, byte[] buffer)
            => Z0.MemoryExtractor.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IMemoryExtractParser MemoryExtractParser(this IContext context, byte[] buffer)
            => Z0.MemoryExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IMemberExtractReader MemberExtractReader(this IContext context, IApiSet api)
            => Z0.MemberExtractReader.Create(context.MemberLocator(), api);


        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IContext context)
            => CaptureService.Create(context);

        /// <summary>
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        [MethodImpl(Inline)]
        public static IAsmInstructionFlow InstructionFlow(this IContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);

        public static CaptureExchange CaptureExchange(this IContext context, int? size = null)
        {
            const int DefaultBufferLen = 1024*8;
            var control = MemberCaptureControl.New(context);
            var cBuffer = new byte[size ?? DefaultBufferLen];
            var sBuffer = new byte[size ?? DefaultBufferLen];
            return Svc.CaptureExchange.Create(control, cBuffer, sBuffer);
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

        public static void WriteDiagnostic(this StreamWriter writer, Option<ApiMemberCapture> mayhaps)
        {
            if(mayhaps.IsNone())
                return;
            var definite = mayhaps.Value;

            var data = definite.Parsed;
            var dst = text.build();
			dst.AppendLine($"; label   : {definite.OpSig}");
			dst.AppendLine($"; location: {definite.AddressRange.Format()}, length: {definite.AddressRange.Length} bytes");
            var lines = data.Bytes.FormatHexLines(null);
            dst.Append(lines.Concat(Chars.Eol));
            dst.AppendLine(new string('_',80));
            writer.Write(dst.ToString());
        }

        public static void WriteHexLine(this IBitArchiveWriter writer, in ApiMemberCapture src, int? idpad = null)
            => writer.WriteCode(EncodedHexLine.Define(src.OpId, src.Extracted.Bytes),idpad); 


        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(this IContext context, AsmFormatConfig config)
            => AsmDecoder.formatter(context,config);

        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(this IContext context)
            => context.AsmFormatter(AsmFormatConfig.DefaultStreamFormat);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IFunctionStreamWriter AsmWriter(this IContext context, FilePath dst, AsmFormatConfig config)
            => AsmDecoder.writer(context,dst,config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IFunctionStreamWriter AsmWriter(this IContext context, FilePath dst, IAsmFormatter formatter)
            => AsmDecoder.writer(context, dst, formatter);

        [MethodImpl(Inline)]
        public static AsmWriterFactory AsmWriterFactory(this IContext context)
            => AsmDecoder.writerFactory(context);

        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder AsmFunctionDecoder(this IContext context, AsmFormatConfig format = null)
            => AsmDecoder.function(context, format);

        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder AsmInstructionDecoder(this IContext context, AsmFormatConfig format)
            => AsmDecoder.instruction(context,format);

        public static IAsmInstructionSource ToInstructionSource(this IHostBitsArchive archive, IContext context, AsmFormatConfig format = null)
        {
            IEnumerable<AsmInstructionList> Enumerate()
            {            
                var decoder = AsmDecoder.instruction(context, format ?? AsmFormatConfig.New);
                foreach(var codeblock in archive.Read())
                {                    
                    var decoded = decoder.DecodeInstructions(codeblock);
                    if(decoded)
                        yield return decoded.Value;                
                }
            }
        
            return AsmInstructionSource.From(Enumerate);
        }
    }
}