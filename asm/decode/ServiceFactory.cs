//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Seed;

    public static class ServiceFactory
    {
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
        /// Instantiates a contextual function archive service that is specialized for an assembly and api host
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog identity</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IHostAsmArchiver FunctionArchive(this IContext context, IApiHost host)
            => context.FunctionArchive(host.Owner, host.HostName, context.AsmFormatter());

        [MethodImpl(Inline)]
        public static IHostAsmArchiver ImmFunctionArchive(this IContext context, ApiHostUri host, FolderPath dst)
            => context.ImmFunctionArchive(host, context.AsmFormatter(), dst);

        [MethodImpl(Inline)]
        public static IMemoryCapture MemoryCapture(this IContext context, int? bufferlen = null)
            => context.MemoryCapture(context.AsmInstructionDecoder(AsmFormatConfig.New), bufferlen);

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

        public static IAsmInstructionSource ToInstructionSource(this IHostCodeArchive archive, IContext context, AsmFormatConfig format = null)
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