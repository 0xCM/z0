//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface TAsmCore : TIdentities, IArchiveServices, TDynops
    {         
        /// <summary>
        /// Writer factory accessor
        /// </summary>
        AsmWriterFactory AsmWriterFactory
            => AsmRoutineWriter.Factory;

        /// <summary>
        /// Default asm formatter accessor
        /// </summary>
        IAsmFormatter DefaultFormatter
        {
            [MethodImpl(Inline)]
            get => AsmFormatter.Default;
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
        AsmRoutineWriter AsmWriter(FilePath dst)
            => new AsmRoutineWriter(dst, DefaultFormatter);  

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a specified formatter
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="formatter">The formatter to use</param>
        AsmRoutineWriter AsmWriter(FilePath dst, IAsmFormatter formatter)
            => new AsmRoutineWriter(dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        AsmRoutineWriter AsmWriter(FilePath dst, in AsmFormatSpec config)
            => new AsmRoutineWriter(dst, DefaultFormatter);  

        /// <summary>
        /// Creates a cil function formatter with an optionally-specified configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        CilFunctionFormatter CilFormatter(CilFormatConfig? config = null)          
            => new CilFunctionFormatter(config);

        /// <summary>
        /// Creates a host-specific archiver service
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="formatter">The formatter to use</param>
        /// <param name="dst">The archive target</param>
        HostAsmArchiver HostArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new HostAsmArchiver(host, formatter, z.insist(dst));
    }
}