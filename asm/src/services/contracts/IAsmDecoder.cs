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

    using Z0.AsmSpecs;

    using static zfunc;

    public interface IAsmDecoder
    {
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        AsmInstructionList DecodeList(AsmCode src);

        /// <summary>
        /// Decodes a function from a native capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        AsmFunction DecodeFunction(MemberCapture src);    

        /// <summary>
        /// Decodes a function from a method
        /// </summary>
        /// <param name="src">The cource capture</param>
        AsmFunction DecodeFunction(Moniker id, MethodInfo src);      

        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="id">The identity to confer</param>
        /// <param name="src">The source delegate</param>
        AsmFunction DecodeFunction(DynamicDelegate src);
    }
}