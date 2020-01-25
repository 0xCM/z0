//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using AsmSpecs;


    public interface IAsmCodeArchive : IAsmArchive
    {
        /// <summary>
        /// Materializes an untyped code block from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        Option<AsmCode> ReadCode(Moniker m);

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        Option<AsmCode<T>> ReadCode<T>(Moniker m, T t = default)
            where T : unmanaged;

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The match predicate</param>
        IEnumerable<FilePath> CodeFiles(string match);        
    }
}