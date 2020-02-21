//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zfunc;

    [Flags]
    public enum SequenceFormatKind
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