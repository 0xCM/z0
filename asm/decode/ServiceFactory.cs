//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Core;

    using Svc = Z0.Asm;

    public static class AsmDecodingServices
    {
        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(this IContext context, AsmFormatConfig config = null)
            => AsmDecoder.formatter(context,config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IContext context, FilePath dst, AsmFormatConfig config)
            => AsmDecoder.writer(context,dst,config);

        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder AsmFunctionDecoder(this IContext context, AsmFormatConfig format = null)
            => AsmDecoder.function(context, format);

        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder AsmInstructionDecoder(this IContext context, AsmFormatConfig format)
            => AsmDecoder.instruction(context,format);

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive, IAsmContext context)
        {
            IEnumerable<AsmInstructionList> Enumerate()
            {            
                var decoder = AsmDecoder.instruction(context, context.AsmFormat);
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