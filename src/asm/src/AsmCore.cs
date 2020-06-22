//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct AsmCore : IAsmCore
    {
        public static IAsmCore Services => default(AsmCore);
    }

    /// <summary>
    /// Defines factory methods that produce context-free services that require no *unsupplied* state to operate 
    /// </summary>
    public interface IAsmCore : IStateless<AsmCore>, IIdentities, TArchives, IDynops
    {        
        /// <summary>
        /// Writer factory accessor
        /// </summary>
        AsmWriterFactory AsmWriterFactory
            => AsmFunctionWriter.Factory;

        /// <summary>
        /// Function Builder service accessor
        /// </summary>
        IAsmFunctionBuilder FunctionBuilder 
            => AsmFunctionBuilder.Service;

        /// <summary>
        /// Memory Reader service accessor
        /// </summary>
        IMemoryReader MemoryReader
            => Z0.MemoryReader.Service;

        /// <summary>
        /// Default asm formatter accessor
        /// </summary>
        IAsmFormatter DefaultFormatter
        {
            [MethodImpl(Inline)]
            get => AsmFormatter.Default;
        }

        /// <summary>
        /// Accessor for default CIL formatter
        /// </summary>
        /// <param name="config">The format configuration</param>
        ICilFunctionFormatter DefaultCilFormatter
        {
            [MethodImpl(Inline)]
            get => CilFormatter(null);
        }

        /// <summary>
        /// Creates an asm formatter with an optional configuration
        /// </summary>
        /// <param name="config">The format configuration, if any</param>
        [MethodImpl(Inline)]
        IAsmFormatter Formatter(in AsmFormatSpec? config = null)
            => Asm.AsmFormatter.Create(config ?? AsmFormatSpec.Default);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with the default formatter
        /// </summary>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        IAsmFunctionWriter AsmWriter(FilePath dst)
            => AsmFunctionWriter.Create(dst, DefaultFormatter);  

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a specified formatter
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="formatter">The formatter to use</param>
        [MethodImpl(Inline)]
        IAsmFunctionWriter AsmWriter(FilePath dst, IAsmFormatter formatter)
            => AsmFunctionWriter.Create(dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        IAsmFunctionWriter AsmWriter(FilePath dst, in AsmFormatSpec config)
            => AsmFunctionWriter.Create(dst, DefaultFormatter);  

        /// <summary>
        /// Creates a cil function formatter with an optionally-specified configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        [MethodImpl(Inline)]
        ICilFunctionFormatter CilFormatter(CilFormatConfig config = null)          
            => CilFunctionFormatter.Create(config);

        /// <summary>
        /// Creates a host-specific archiver service using the default formatter
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="dst">The archive target</param>
        [MethodImpl(Inline)]
        IHostArchiver HostArchiver(ApiHostUri host, FolderPath dst)
            => new HostArchiver(host, DefaultFormatter, insist(dst));

        /// <summary>
        /// Creates a host-specific archiver service
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="formatter">The formatter to use</param>
        /// <param name="dst">The archive target</param>
        [MethodImpl(Inline)]
        IHostArchiver HostArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new HostArchiver(host, formatter, insist(dst));
    }
}