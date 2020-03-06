//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Root;

    public static class AsmQuery
    {
        /// <summary>
        /// Selects a (non-distinct) sequence of far addresses that are target by call instructions in the source function
        /// </summary>
        /// <param name="src">The source functions</param>
        public static IEnumerable<MemoryAddress> FarCalls(this AsmFunction src)
            => from i in src.Instructions
                where i.FlowControl == FlowControl.Call
                    select (MemoryAddress)i.MemoryAddress64;
        
        /// <summary>
        /// Selects a (non-distinct) sequence of the far addresses targeted by functions in the source
        /// </summary>
        /// <param name="src">The source functions</param>
        public static IEnumerable<MemoryAddress> FarCalls(this AsmFunctionList src)
            => src.SelectMany(FarCalls);

        /// <summary>
        /// Selects a (non-distinct) sequence of the far addresses targeted by functions in an extract
        /// </summary>
        /// <param name="src">The source extract</param>
        public static IEnumerable<MemoryAddress> FarCalls(this CapturedHost src)
            => src.Decoded.SelectMany(FarCalls);

        /// <summary>
        /// Selects a (non-distinct) sequence of the far addresses targeted by functions in an extract
        /// </summary>
        /// <param name="src">The source extract</param>
        public static IEnumerable<MemoryAddress> FarCalls(this IEnumerable<CapturedHost> src)
            => src.SelectMany(FarCalls);

        /// <summary>
        /// Selects base addresses of functions in an extract
        /// </summary>
        /// <param name="src">The source extract</param>
        public static IEnumerable<MemoryAddress> BaseAddresses(this CapturedHost src)
            => src.Decoded.Select(f => f.BaseAddress);

        /// <summary>
        /// Selects function base addresss from an extract stream
        /// </summary>
        /// <param name="src">The source extract</param>
        public static IEnumerable<MemoryAddress> BaseAddresses(this IEnumerable<CapturedHost> src)
            => src.SelectMany(BaseAddresses);
    }
}