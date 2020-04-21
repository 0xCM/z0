//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Z0.Asm;

    public static class ServiceFactory    
    {
        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(this IContext context, AsmFormatConfig config)
            => Asm.AsmFormatter.Create(context,config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IContext context, FilePath dst, IAsmFormatter formatter)
            => AsmFunctionWriter.Create(context, dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IContext context, FilePath dst, AsmFormatConfig config)
            => AsmFunctionWriter.Create(context, dst, context.AsmFormatter(config));

        [MethodImpl(Inline)]
        public static AsmWriterFactory AsmWriterFactory(this IContext context)
            => (dst,formatter) => context.AsmWriter(dst,formatter);

    }
}