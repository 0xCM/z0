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
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public static partial class FastOpX
    {
        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn ? Z0.ParamVariance.In  : src.IsOut ? Z0.ParamVariance.Out  : src.ParameterType.IsByRef ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;

        public static string Keyword(this ParamVariance src)        
            => src switch{
                ParamVariance.In => "in",
                ParamVariance.Out => "out",
                ParamVariance.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamVariance src)
            => src != ParamVariance.None ? parenthetical(src.Keyword()) : string.Empty;
        
        public static Moniker Identity(this IMethodMetadata src)
            => src.Element.Identity();

        public static IEnumerable<MethodInfo> Vectorized<T>(this IEnumerable<MethodInfo> src, N128 w)
            where T : unmanaged
        {
            var match = typeof(Vector128<>).MakeGenericType(typeof(T));
            return src.Where(m => m.GetParameters().Length != 0 && m.GetParameters().Any(p => p.ParameterType == match));
        }

        public static IEnumerable<MethodInfo> Vectorized<T>(this IEnumerable<MethodInfo> src, N256 w)
            where T : unmanaged
        {
            var match = typeof(Vector256<>).MakeGenericType(typeof(T));
            return src.Where(m => m.GetParameters().Length != 0 && m.GetParameters().Any(p => p.ParameterType == match));
        }

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

        public static IEnumerable<M> Generic<M>(this IEnumerable<M> src)
            where M : IMethodMetadata
                => from m in src
                where m.Element.IsGenericMethod
                    select m;

        public static IEnumerable<M> NonGeneric<M>(this IEnumerable<M> src)
            where M : IMethodMetadata
                => from m in src
                where !m.Element.IsGenericMethod
                    select m;

        public static IEnumerable<M> WithName<M>(this IEnumerable<M> src, string Name)
            where M : IMethodMetadata
                => from m in src
                    where m.Element.Name == Name
                    select m;
    }
}