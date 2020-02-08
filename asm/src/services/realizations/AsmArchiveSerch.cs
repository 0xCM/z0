//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines lookup capability over all archived files
    /// </summary>
    readonly struct AsmArchiveSearch : IAsmArchiveSearch
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmArchiveSearch Create(IAsmContext context)
            => new AsmArchiveSearch(context);
        
        [MethodImpl(Inline)]
        AsmArchiveSearch(IAsmContext context)
        {
            this.Context = context;
        }
    }

    partial interface IAsmArchiveSearch
    {
        // static IEnumerable<FilePath> HexFiles(AssemblyId assembly, string subject)
        // {

        // }

    }

}
