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
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(this IAsmContext context, AsmFormatConfig config = null)
            => Z0.AsmFormatter.Create(context, config ?? context.AsmFormat);

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
        public static IAsmFunctionDecoder AsmFunctionDecoder(this IAsmContext context)
            => Z0.AsmFunctionDecoder.Create(context);

        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder AsmInstructionDecoder(this IAsmContext context)
            => Z0.AsmInstructionDecoder.Create(context);

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive)
        {
            IEnumerable<AsmInstructionList> Enumerate()
            {            
                var decoder = archive.Context.AsmInstructionDecoder();
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