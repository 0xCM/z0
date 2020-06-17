//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
        
    partial class XTend
    {
        /// <summary>
        /// Determines whether a field has been generated by the compiler
        /// </summary>
        /// <param name="f">The field to examine</param>
        public static bool IsCompilerGenerated(this FieldInfo f)
            => f.Tagged<CompilerGeneratedAttribute>();
    }
}