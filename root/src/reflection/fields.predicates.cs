//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static RootShare;
    
    partial class RootReflections
    {
        /// <summary>
        /// Determines whether a field has been generated by the compiler
        /// </summary>
        /// <param name="f">The field to examine</param>
        [MethodImpl(Inline)]
        public static bool IsCompilerGenerated(this FieldInfo f)
            => f.Attributed<CompilerGeneratedAttribute>();
    }
}