//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    [Flags]
    public enum SeqFmtKind
    {        
        /// <summary>
        /// Indicates a sequence of values is formatted as a comma-delimited 
        /// list between left/right square brackets, e.g., [1, 2, ..., n]
        /// </summary>
        List = 1,

        /// <summary>
        /// Indicates a sequence of values is formatted as a comma-delimited 
        /// list between left/right angular brackets
        /// </summary>
        Vector = 2


    }

}