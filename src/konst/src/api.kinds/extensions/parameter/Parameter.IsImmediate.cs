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

    using static ImmFunctionClass;

    partial class XKinds
    {
        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        [Op]
        public static bool IsImmediate(this ParameterInfo param, ScalarRefinementKind refinement)
        {
            if(param.Tagged<ImmAttribute>())
            {
                var refined = param.ParameterType.IsEnum;
                if(refined)
                {
                    if(refinement == ScalarRefinementKind.Refined || refinement == ScalarRefinementKind.All)
                        return true;
                }
                else
                {
                    if(refinement == ScalarRefinementKind.Unrefined)
                        return true;
                }

            }
            return false;
        }

        [Op]
        public static Imm8R[] ToImm8Values(this byte[] src, ScalarRefinementKind kind)
            => src.Map(x => new Imm8R(x));

        [Op]
        public static Imm8R[] ToImm8Values(this IEnumerable<byte> src, ScalarRefinementKind kind)
            => src.Map(x => new Imm8R(x));

        /// <summary>
        /// Determines whether a parameters is an unrefined immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        [Op]
        public static bool IsUnrefinedImmediate(this ParameterInfo src)
            => src.Tagged<ImmAttribute>() && !src.ParameterType.IsEnum;

        /// <summary>
        /// Determines whether a parameters is a refined immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        [Op]
        public static bool IsRefinedImmediate(this ParameterInfo src)
            => src.Tagged<ImmAttribute>() && src.ParameterType.IsEnum;

        /// <summary>
        /// Returns a method's immediate parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static Type[] ImmParameterTypes(this MethodInfo src, ScalarRefinementKind kind)
            => src.ImmParameters(kind).Select(p => p.ParameterType);

        [Op]
        static ImmFunctionClass ImmSlot(this ParameterInfo p)
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