//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    partial class FastOpX
    {     
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => Identity.identify(m);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => Identity.host(t);
        
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string OpName(this MethodInfo m)
            => Identity.name(m);

        public static Option<ScalarIdentity> Scalar(this OpIdentityPart part)
            => Identity.scalar(part);

        public static Option<OpIdentityPart> Part(this OpIdentity src, int partidx)
            => Identity.part(src,partidx);

        public static Option<OpIdentitySegment> Segment(this OpIdentityPart part)
            => Identity.segment(part);

        public static Option<OpIdentitySegment> Segment(this OpIdentity src, int partidx)
            => Identity.segment(src,partidx);

        public static Option<byte> Imm8(this OpIdentity src)            
            => Identity.imm8(src);

        public static OpIdentity WithoutImm8(this OpIdentity src)
            => Identity.imm8Remove(src);
    
        public static OpIdentity WithImm8(this OpIdentity src, byte immval)
            => Identity.imm8Add(src,immval);

        public static Option<string> NatSpanIdentity(this Type src)
        {
            if(src.IsNatSpan())
            {
                var typeargs = src.GetGenericArguments().ToArray();                    
                var text = "ns";
                text += typeargs[0].NatValue();
                text += OpIdentity.SegSep;
                text += NumericType.signature(typeargs[1]);
                return text;
            }
            else
                return default;
        }

        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVariance.In  : src.IsOut 
            ? Z0.ParamVariance.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;

        public static bool IsSome(this ParamVariance src)        
            => src != ParamVariance.None;

        public static string Keyword(this ParamVariance src)        
            => src switch{
                ParamVariance.In => "in",
                ParamVariance.Out => "out",
                ParamVariance.Ref => "ref",    
                _ => string.Empty
            };

        public static GenericKind GetGenericKind(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GenericKind.Open 
               : src.IsClosedGeneric(false) ? GenericKind.Closed 
               : src.IsGenericTypeDefinition ? GenericKind.Definition 
               : GenericKind.None;

        public static GenericKind GetGenericKind(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? GenericKind.Open 
               : src.IsClosedGeneric() ? GenericKind.Closed 
               : src.IsGenericMethodDefinition ? GenericKind.Definition 
               : GenericKind.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this GenericKind kind)
            => kind != GenericKind.None;


        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        public static TypeParameter[] TypeParameters(this MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => TypeParameter.Define(t.DisplayName(), i, t.IsGenericType));

        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static NumericKind TypeParameterKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.NumericKind() ?? Z0.NumericKind.None;
    }
}