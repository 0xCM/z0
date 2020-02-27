//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using Z0.Asm;

    using static Root;

    public static class AsmDecodingServices
    {
        /// <summary>
        /// Instantiates an internal instruction formatter service
        /// </summary>
        /// <param name="context">The configuration to use</param>
        [MethodImpl(Inline)]
        internal static IAsmInstructionFormatter InstructionFormatter(this IAsmContext context)
            => AsmFunctionFormatter.BaseFormatter(context);    

        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionFormatter AsmFormatter(this IAsmContext context, AsmFormatConfig config = null)
            => AsmFunctionFormatter.Create(context, config ?? context.AsmFormat);

        public static IClrIndex CreateIndex(this Assembly src)
            => ClrMetadataIndex.Create(src);

        /// <summary>
        /// Allocates a caller-disposed asm text writer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IAsmContext context, FilePath dst)
            => AsmFunctionWriter.Create(context, context.AsmFormat, dst);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IAsmContext context, AsmFormatConfig config, FilePath dst)
            => AsmFunctionWriter.Create(context, config, dst);

        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder FunctionDecoder(this IAsmContext context)
            => AsmFunctionDecoder.Create(context);

        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder InstructionDecoder(this IAsmContext context)
            => AsmInstructionDecoder.Create(context);


        static IEnumerable<AsmInstructionList> GetInstructions(IAsmCodeArchive archive)
        {            
            var decoder = archive.Context.InstructionDecoder();
            foreach(var codeblock in archive.Read())
                yield return decoder.DecodeInstructions(codeblock);                
        }

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive)
            => AsmInstructionSource.FromProducer(() => GetInstructions(archive));
    }
}