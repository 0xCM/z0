//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Svc = Z0.Asm;

    public static class AsmDecoder
    {
        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder function(IContext context, AsmFormatConfig format = null)
            => Svc.AsmFunctionDecoder.Create(context, format ?? AsmFormatConfig.New);

        /// <summary>
        /// Creates an instruction decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder instruction(IContext context, AsmFormatConfig format = null)
            => Svc.AsmInstructionDecoder.Create(context,format ?? AsmFormatConfig.New);

        /// <summary>
        /// Allocates a caller-disposed asm function writer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IFunctionStreamWriter writer(IContext context, FilePath dst, AsmFormatConfig config = null)
            => AsmFunctionWriter.Create(context, dst, formatter(context, config));

        /// <summary>
        /// Allocates a caller-disposed asm function writer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IFunctionStreamWriter writer(IContext context, FilePath dst, IAsmFormatter formatter)
            => AsmFunctionWriter.Create(context, dst, formatter);

        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter formatter(IContext context, AsmFormatConfig config = null)
            => Svc.AsmFormatter.Create(context, config ?? AsmFormatConfig.New);        
    }
}