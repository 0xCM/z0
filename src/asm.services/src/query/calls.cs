//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial struct AsmQueries
    {
        /// <summary>
        /// Selects a (non-distinct) sequence of far addresses that are target by call instructions in the source function
        /// </summary>
        /// <param name="src">The source functions</param>
        public static MemoryAddress[] calls(AsmRoutine src)
            => (from i in src.Instructions
                where i.FlowControl == FlowControl.Call
                    select (MemoryAddress)i.MemoryAddress64).Array();

        /// <summary>
        /// Selects a (non-distinct) sequence of addresses targeted by functions in the source
        /// </summary>
        /// <param name="src">The source functions</param>
        public static MemoryAddress[] calls(AsmRoutines src)
            => src.Data.SelectMany(calls).Array();
    }
}