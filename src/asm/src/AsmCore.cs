//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class XTend
    {
        public static T Map<S,T>(this S src, Func<S,T> f, T @default = default)
            where S : INullaryKnown
        {
            if(src.IsNonEmpty)
                return f(src);
            else 
                return default;
        }
    }
    
    public readonly struct AsmCore : IAsmCore
    {
        public static IAsmCore Services => default(AsmCore);
    }

    /// <summary>
    /// Defines factory methods that produce context-free services that require no *unsupplied* state to operate 
    /// </summary>
    public interface IAsmCore : IStatelessFactory<AsmCore>, IIdentities, IArchives, IDynops
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
            => AsmFunctionWriter.Create(dst, AsmCore.Services.AsmFormatter(config));  

        /// <summary>
        /// Initializes a cil function formatter with an optionally-specified configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        [MethodImpl(Inline)]
        ICilFunctionFormatter CilFormatter(CilFormatConfig config = null)          
            => CilFunctionFormatter.Create(config);

        [MethodImpl(Inline)]
        IHostArchiver HostArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new HostArchiver(host, formatter, insist(dst));

    }
}