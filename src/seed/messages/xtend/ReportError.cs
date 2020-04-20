//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices; 
    using System.Text;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Emits an exception to the error output stream
        /// </summary>
        /// <param name="e">The exection to emit</param>
        public static void Report(this Exception e)
            => Terminal.Get().Error(e);
    }
}