//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    partial struct IceExtractors
    {
        /// <summary>
        /// Selects a (non-distinct) sequence of far addresses that are target by call instructions in the source function
        /// </summary>
        /// <param name="src">The source functions</param>
        public static MemoryAddress[] CallAddresses(AsmRoutine src)
            => (from i in src.Instructions
                where i.Instruction.FlowControl == IceFlowControl.Call
                    select (MemoryAddress)i.Instruction.MemoryAddress64).Array();

        /// <summary>
        /// Selects a (non-distinct) sequence of addresses targeted by functions in the source
        /// </summary>
        /// <param name="src">The source functions</param>
        public static MemoryAddress[] CallAddresses(AsmRoutines src)
            => src.SelectMany(CallAddresses).Array();
    }
}