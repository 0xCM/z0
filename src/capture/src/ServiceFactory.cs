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
    using static Memories;

    public static class AsmCoreServices
    {                       
        public static IHostCodeExtractor HostExtractor(this IServiceFactory factory, int? bufferlen = null)
            => HostCodeExtractor.Create(factory.Context, bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IServiceFactory factory)
            => CaptureService.Create(DivinationContext.Create(factory.Context, factory.MultiDiviner()));

        [MethodImpl(Inline)]
        public static IMemoryExtractor MemoryExtractor(this IServiceFactory factory, byte[] buffer)
            => Z0.MemoryExtractor.Create(factory.Context, buffer);

        [MethodImpl(Inline)]
        public static IHostCodeExtractor HostExtractor(this IContext context, int? bufferlen = null)
            => HostCodeExtractor.Create(context, bufferlen ?? Pow2.T14);


        [MethodImpl(Inline)]
        public static IMemoryExtractParser MemoryExtractParser(this IContext context, byte[] buffer)
            => Z0.MemoryExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IMemberExtractReader MemberExtractReader(this IContext context, IApiSet api)
            => Z0.MemberExtractReader.Create(context.MemberLocator(), api);

        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IContext context)
            => CaptureService.Create(DivinationContext.Create(context, context.MultiDiviner()));

        /// <summary>
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        [MethodImpl(Inline)]
        public static IAsmInstructionFlow InstructionFlow(this IContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);

        public static CaptureExchange CaptureExchange(this IAsmContext context)
        {
            var size = context.DefaultBufferLength;                                    
            var control = context.CaptureControl;            
            var cBuffer = new byte[size];
            var sBuffer = new byte[size];
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