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

    public class AsmServices
    {
        public static AsmWriterFactory AsmWriterFactory
            => AsmFunctionWriter.Factory();

        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(AsmFormatConfig config = null)
            => Asm.AsmFormatter.Create(config ?? AsmFormatConfig.New);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(FilePath dst, IAsmFormatter formatter)
            => AsmFunctionWriter.Create(dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(FilePath dst, AsmFormatConfig config = null)
            => AsmFunctionWriter.Create(dst, AsmServices.AsmFormatter(config));
    }
}