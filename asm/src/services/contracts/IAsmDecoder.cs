//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public interface IAsmDecoder
    {
        /// <summary>
        /// Decodes an assembly function from native member data
        /// </summary>
        /// <param name="src">The source data</param>
        AsmFunction DecodeFunction(NativeMemberCapture src);

        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="id">The identity to confer upon the result</param>
        /// <param name="src">The source delegate</param>
        AsmFunction DecodeFunction(Moniker id, DynamicDelegate src);

        /// <summary>
        /// Decodes an assembly function from a method
        /// </summary>
        /// <param name="id">The identity to confer upon the result</param>
        /// <param name="src">The source method</param>
        AsmFunction DecodeFunction(Moniker id, MethodInfo src);

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="src">The encoded assembly</param>
        /// <param name="location">The memory location from which the code was extracted</param>
        AsmFunction DecodeFunction(AsmCode src, MemoryRange location);


    }
}