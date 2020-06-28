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

    public readonly struct AsmCore : TAsmCore
    {
        public static TAsmCore Services => default(AsmCore);
    }

    /// <summary>
    /// Defines factory methods that produce context-free services that require no *unsupplied* state to operate 
    /// </summary>
    public interface TAsmCore : IIdentities, TArchives, TDynops
    {        
        /// <summary>
        /// Writer factory accessor
        /// </summary>
        AsmWriterFactory AsmWriterFactory
            => AsmFunctionWriter.Factory;

        /// <summary>
        /// Function Builder service accessor
        /// </summary>
        AsmFunctionBuilder FunctionBuilder 
            => AsmFunctionBuilder.Service;

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
        CilFunctionFormatter DefaultCilFormatter
        {
            [MethodImpl(Inline)]
            get => CilFormatter();
        }

        /// <summary>
        /// Creates an asm formatter with an optional configuration
        /// </summary>
        /// <param name="config">The format configuration, if any</param>
        AsmFormatter Formatter(in AsmFormatSpec? config = null)
            => new AsmFormatter(config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with the default formatter
        /// </summary>
        /// <param name="dst">The target path</param>
        AsmFunctionWriter AsmWriter(FilePath dst)
            => new AsmFunctionWriter(dst, DefaultFormatter);  

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a specified formatter
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="formatter">The formatter to use</param>
        AsmFunctionWriter AsmWriter(FilePath dst, IAsmFormatter formatter)
            => new AsmFunctionWriter(dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        AsmFunctionWriter AsmWriter(FilePath dst, in AsmFormatSpec config)
            => new AsmFunctionWriter(dst, DefaultFormatter);  

        /// <summary>
        /// Creates a cil function formatter with an optionally-specified configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        CilFunctionFormatter CilFormatter(CilFormatConfig config = null)          
            => new CilFunctionFormatter(config);

        /// <summary>
        /// Creates a host-specific archiver service
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="formatter">The formatter to use</param>
        /// <param name="dst">The archive target</param>
        HostArchiver HostArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new HostArchiver(host, formatter, insist(dst));
    }
}