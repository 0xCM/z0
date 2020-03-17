//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Root;
 
    public static partial class ReflectedClass
    {
        /// <summary>
        /// Returns the source method's kind identifier if it exists
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static OpKindId? KindId(this MethodInfo m)
            => m.Tag<OpKindAttribute>().MapValueOrNull(a => a.KindId);

        /// <summary>
        /// Determines whether the method has a kind identifier
        /// </summary>
        /// <param name="m">The source method</param>
        public static bool IsKinded(this MethodInfo m)
            => m.KindId().HasValue;

        /// <summary>
        /// Determines whether a method defines an operator with identified kind
        /// </summary>
        /// <param name="m">The source method</param>
        public static bool IsKindedOperator(this MethodInfo m)
            => m.IsKinded() && m.IsOperator();

        /// <summary>
        /// Queries the stream for methods that have a nonemtpy kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        public static IEnumerable<MethodInfo> Kinded(this IEnumerable<MethodInfo> src)
            => src.Where(IsKinded);

        /// <summary>
        /// Queries the stream for mathods that are of a specified kind
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> Kinded(IEnumerable<MethodInfo> src, OpKindId kind)
            => from m in src where m.KindId() == kind select m;

        /// <summary>
        /// Queries the stream for methods that have a nonemtpy kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> KindedOperators(this IEnumerable<MethodInfo> src)
            => src.Where(IsKindedOperator);

        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamVarianceClass ClassifyVariance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVarianceClass.In  : src.IsOut 
            ? Z0.ParamVarianceClass.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVarianceClass.Ref : Z0.ParamVarianceClass.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamVarianceClass src)        
            => src != ParamVarianceClass.None;

        public static string Keyword(this ParamVarianceClass src)        
            => src switch{
                ParamVarianceClass.In => "in",
                ParamVarianceClass.Out => "out",
                ParamVarianceClass.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamVarianceClass src)
            => src.IsSome() ? ('~' + src.Keyword()) : string.Empty;      

        public static TypedOperatorClass ClassifyTypedOperator(this MethodInfo src)
            => TypedOperatorClass.Infer(src); 
    }
}