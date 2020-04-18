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

    public enum ImmSourceKind : byte
    {
        Literal = 0,

        Refinement = 1
    }

    [Flags]
    public enum ImmRefinementKind : byte
    {
        None = 0,

        Unrefined = 1,

        Refined = 2,

        All = Unrefined | Refined
    }

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

        public static Imm8Value[] ToImm8Values(this byte[] src, ImmSourceKind source)
            => src.Map(x => Imm8Value.Define(x,source));

        public static Imm8Value[] ToImm8Values(this IEnumerable<byte> src, ImmSourceKind source)
            => src.Map(x => Imm8Value.Define(x,source));

        public static Imm8Value[] RefinedImmValues(this ParameterInfo param)           
        {
            if(param.IsRefinedImmediate())
                return param.ParameterType.GetEnumValues().Cast<byte>().ToImm8Values(ImmSourceKind.Refinement);
            else 
                return Arrays.empty<Imm8Value>();
        }
        
        public static ImmRefinementKind ClassifyImmRefinement(this ParameterInfo src)
        {
            if(!src.Tagged<ImmAttribute>())
                return ImmRefinementKind.None;
            else
                return src.ParameterType.IsEnum ? ImmRefinementKind.Refined : ImmRefinementKind.Unrefined;
        }

        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsUnrefinedImmediate(this ParameterInfo src)
            => src.Tagged<ImmAttribute>() && !src.ParameterType.IsEnum;

        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsRefinedImmediate(this ParameterInfo src)
            => src.Tagged<ImmAttribute>() && src.ParameterType.IsEnum;

        /// <summary>
        /// Determines the imm refinement type, if any
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static Option<Type> ImmRefinementType(this ParameterInfo src)
            => src.IsRefinedImmediate() ? Option.some(src.ParameterType) : Option.none<Type>();

        /// <summary>
        /// Selects parameters from a method, if any, that acceptrequire an immediate value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> ImmParameters(this MethodInfo src, ImmRefinementKind refinement)
        {
            var refined = src.GetParameters().Where(p => p.IsRefinedImmediate());
            var unrefined = src.GetParameters().Where(p => p.IsUnrefinedImmediate());
            if(refinement == ImmRefinementKind.All)
                return refined.Concat(unrefined);
            else if(refinement == ImmRefinementKind.Refined)
                return refined;
            else
                return unrefined;
        }

        /// <summary>
        /// Returns a method's immediate parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ImmParameterTypes(this MethodInfo src, ImmRefinementKind refinement)
            => src.ImmParameters(refinement).Select(p => p.ParameterType);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo src, ImmRefinementKind refinement) 
            => src.ImmParameters(refinement).Any();

        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo src) 
            => src.Parameters(p => p.Tagged<ImmAttribute>()).Any();

        /// <summary>
        /// Determines whether a method defines an index-identified parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m, int index, ImmRefinementKind refinement)
        {
            var parameters = m.GetParameters().ToArray();
            return parameters.Length > index && parameters[index].IsImmediate(refinement);
        }

        /// <summary>
        /// Calculates a method's immediate class
        /// </summary>
        /// <param name="src">The method to classify</param>
        public static ImmFunctionClass ImmFunctionClass(this MethodInfo src, ImmRefinementKind refinement)
        {
            var parms = src.ImmParameters(refinement).ToArray();
            var count = parms.Length;
            if(count == 0 || count > 2)
                return 0;

            var immc = Imm8;
            var first = parms.First();
            switch(count)
            {
                case 1:
                    immc |= ImmCount1;
                    immc |= first.ImmSlot();
                break;

                case 2:
                    var second = parms.Last();
                    immc |= ImmCount2;
                    immc |= first.ImmSlot();
                    immc |= second.ImmSlot();
                break;
            }
            
            return immc;
        } 

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

        /// <summary>
        /// Determines whether a method is (partially) vectorized and accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedImm(this MethodInfo src, ImmRefinementKind refinment)
            => src.IsVectorized() && src.AcceptsImmediate(refinment) && src.ReturnsVector();
        
        /// <summary>
        /// Determines whether a method is a vectorized unary operator that accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedUnaryImm(this MethodInfo src, ImmRefinementKind refinement)
        {
            var parameters = src.GetParameters().ToArray();
            return parameters.Length == 2 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].IsImmediate(refinement)
                && src.ReturnsVector();
        }

        /// <summary>
        /// Determines whether a method is a vectorized binary operator that accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedBinaryImm(this MethodInfo src, ImmRefinementKind refinment)
        {
            var parameters = src.GetParameters().ToArray();
            return parameters.Length == 3 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].ParameterType.IsVector() 
                && parameters[2].IsImmediate(refinment)
                && src.ReturnsVector();
        } 
    }
}