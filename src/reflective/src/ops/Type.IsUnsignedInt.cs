//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a type is a system-defined and architecture-supported signed integral type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsUnsignedInt(this Type t)
            => t.IsUInt8() || t.IsUInt16() || t.IsUInt32() || t.IsUInt64();

    }
}