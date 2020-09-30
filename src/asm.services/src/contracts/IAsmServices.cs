//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IAsmServices : TIdentities, IDynamic
    {

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
        AsmFormatter Formatter(in AsmFormatConfig? config = null)
            => new AsmFormatter(config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a specified formatter
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="formatter">The formatter to use</param>
        AsmWriter AsmWriter(FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst, formatter);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        AsmWriter AsmWriter(FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, DefaultFormatter);

        /// <summary>
        /// Creates a host-specific archiver service
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="formatter">The formatter to use</param>
        /// <param name="dst">The archive target</param>
        AsmImmWriter HostArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new AsmImmWriter(host, formatter, z.insist(dst));
    }
}