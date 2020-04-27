//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmStateless : IAsmStateless
    {
        public static IAsmStateless Factory => default(AsmStateless);
    }

    /// <summary>
    /// Defines factory methods that produce context-free services that require 
    /// no *unsupplied* state to operate
    /// </summary>
    public interface IAsmStateless : IStatelessFactory<AsmStateless>, IStatelessIdentity
    {
        AsmWriterFactory AsmWriterFactory
            => AsmFunctionWriter.Factory;

        IAsmFunctionBuilder FunctionBuilder 
            => AsmFunctionBuilder.Service;

        IMemoryReader MemoryReader
            => Z0.MemoryReader.Service;

        [MethodImpl(Inline)]
        IAsmFormatter AsmFormatter(in AsmFormatSpec? config = null)
            => Asm.AsmFormatter.Create(config ?? AsmFormatSpec.Default);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        IAsmFunctionWriter AsmWriter(FilePath dst, IAsmFormatter formatter)
            => AsmFunctionWriter.Create(dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        IAsmFunctionWriter AsmWriter(FilePath dst, in AsmFormatSpec? config = null)
            => AsmFunctionWriter.Create(dst, AsmStateless.Factory.AsmFormatter(config));  

        /// <summary>
        /// Initializes a cil function formatter with an optionally-specified configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        [MethodImpl(Inline)]
        ICilFunctionFormatter CilFormatter(CilFormatConfig config = null)          
            => CilFunctionFormatter.Create(config);
    }
}