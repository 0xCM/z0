//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    /// <summary>
    /// Defines service contract for asm text formatting support
    /// </summary>
    public interface IAsmFunctionFormatter : IAsmService
    {
        /// <summary>
        /// The configuration used when rendering the formatted text
        /// </summary>
        AsmFormatConfig Config {get;}        
        
        /// <summary>
        /// Creates a detailed presentation of decoded x86 asm data per the accompanying configuration spec
        /// </summary>
        /// <param name="src">The function to render as asm text</param>
        string FormatDetail(AsmFunction src);        
    }
}


