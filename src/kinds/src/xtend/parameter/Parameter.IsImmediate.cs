//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static ImmFunctionClassKind;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsImmediate(this ParameterInfo param, ImmRefinementKind refinement)
        {
            if(param.Tagged<ImmAttribute>())
            {
                var isrefined = param.ParameterType.IsEnum;
                if(isrefined)
                {
                    if(refinement == ImmRefinementKind.Refined || refinement == ImmRefinementKind.All)
                        return true;
                }
                else
                {
                    if(refinement == ImmRefinementKind.Unrefined)
                        return true;
                }
                
            }
            return false;
        }

        public static Imm8R[] ToImm8Values(this byte[] src, ImmRefinementKind kind)
            => src.Map(x => new Imm8R(x, kind != 0));

        public static Imm8R[] ToImm8Values(this IEnumerable<byte> src, ImmRefinementKind kind)
            => src.Map(x => new Imm8R(x, kind != 0));
        
        /// <summary>
        /// Determines whether a parameters is an unrefined immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsUnrefinedImmediate(this ParameterInfo src)
            => src.Tagged<ImmAttribute>() && !src.ParameterType.IsEnum;

        /// <summary>
        /// Determines whether a parameters is a refined immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsRefinedImmediate(this ParameterInfo src)
            => src.Tagged<ImmAttribute>() && src.ParameterType.IsEnum;

        /// <summary>
        /// Returns a method's immediate parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ImmParameterTypes(this MethodInfo src, ImmRefinementKind kind)
            => src.ImmParameters(kind).Select(p => p.ParameterType);

        static ImmFunctionClassKind ImmSlot(this ParameterInfo p)
        {
            switch(p.Position)
            {
                case 0:
                    return ImmSlot0;
                case 1:
                    return ImmSlot1;
                case 2:
                    return ImmSlot2;
                case 3:
                    return ImmSlot3;
                case 4:
                    return ImmSlot4;
                default:
                    return 0;
            }
        }
    }
}