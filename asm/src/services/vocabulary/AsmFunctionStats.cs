//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;                

    /// <summary>
    /// Defines a collection of metrics describing a single asm function
    /// </summary>
    public class AsmFunctionStats
    {   

        /// <summary>
        /// The function identifier
        /// </summary>
        public Moniker Id {get;}


        /// <summary>
        /// The memory location from which the code was taken
        /// </summary>
        public MemoryRange Location {get;}


    }
}