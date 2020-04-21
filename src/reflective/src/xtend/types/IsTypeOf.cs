//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether a source type is predicated on a specified match type, including nullable wrappers, references and enums
        /// </summary>
        /// <typeparam name="T">The type to match</typeparam>
        /// <param name="candidate">The source type</param>
        /// <param name="match">The type to match</param>
        public static bool IsTypeOf(this Type candidate, Type match)
            => candidate.EffectiveType() == match
            || candidate.EffectiveType().IsNullable(match)
            || candidate.EffectiveType().IsEnum && candidate.EffectiveType().GetEnumUnderlyingType() == match;

        /// <summary>
        /// Determines whether a source type is predicated on a parametric type, including nullable wrappers, references and enums
        /// </summary>
        /// <param name="match">The source type</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static bool IsTypeOf<T>(this Type match)
            => match.EffectiveType() == typeof(T) 
            || match.EffectiveType().IsNullable<T>()
            || match.EffectiveType().IsEnum && match.EffectiveType().GetEnumUnderlyingType() == typeof(T);
    }
}