//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether a type is a system-defined and architecture-supported floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsFloatingPoint(this Type t)
            => t.IsFloat32() || t.IsFloat64();
    }
}