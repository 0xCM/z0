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
    using System.ComponentModel;

    using static RootShare;
 
    partial class RootReflections
    {
        /// <summary>
        /// Returns the arguments supplied to a constructed generic method; if the method is 
        /// nongeneric, a generic type definition or some other variant, an empty result is returned
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static IEnumerable<Type> GenericArguments(this MethodInfo src)
            => src.IsConstructedGenericMethod ? src.GetGenericArguments() : new Type[]{};

        /// <summary>
        /// Returns the generic parameters specified by a generic method definition or, if constructed,
        /// the parameters specified by the definition on which the construction was predicated. If nongeneric,
        /// returns an empty result
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static IEnumerable<Type> GenericParameters(this MethodInfo src)
            => src.IsConstructedGenericMethod ? src.GetGenericMethodDefinition().GetGenericArguments()
             : src.IsGenericMethodDefinition ? src.GetGenericArguments()            
             : new Type[]{};

        /// <summary>
        /// Selects the open generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(IsOpenGeneric);

        /// <summary>
        /// Selects the closed generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> ClosedGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsConstructedGenericMethod);

        /// <summary>
        /// Selects the non-generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.ContainsGenericParameters && !t.IsConstructedGenericMethod);        

        /// <summary>
        /// Selects the open generic methods from a stream with a specified argument count
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="args">The target argument count</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src, int args)
            => src.OpenGeneric().Where(m => m.GetGenericArguments().Length == args);

        /// <summary>
        /// For the generic methods in a stream, selects their respective definitions
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> GenericMethodDefinitions(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsOpenGeneric() || m.IsClosedGeneric()).Select(m => m.GetGenericMethodDefinition()).Distinct();
            
        /// <summary>
        /// For a generic method, retrieves the definition; otherwis, an error is raised
        /// </summary>
        /// <param name="src">The source method</param>
        public static MethodInfo GenericDefintion(this MethodInfo src)
        {
            src.RequireGeneric();

            return src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();
        }

        /// <summary>
        /// Reifies a method if it is open generic; otherwise, returns the original method
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="args">The types over which to close the method</param>
        public static MethodInfo Reify(this MethodInfo m, params Type[] args)
        {
            if(m.IsGenericMethodDefinition)
                return m.MakeGenericMethod(args);            
            else if(m.IsConstructedGenericMethod)
                return m;
            else if(m.IsGenericMethod)
                return m.GetGenericMethodDefinition().MakeGenericMethod(args);
            else
                return m;
        }

        /// <summary>
        /// Reifies a 1-parameter generic method with a parametric type argument
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static MethodInfo CloseGenericMethod<T>(this MethodInfo src)
            => src.GenericDefintion().MakeGenericMethod(typeof(T));

        /// <summary>
        /// Reifies a 2-parameter generic method with a parametric type argument
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static MethodInfo CloseGenericMethod<T1,T2>(this MethodInfo src)
            => src.GenericDefintion().MakeGenericMethod(typeof(T1), typeof(T2));

        /// <summary>
        /// Reifies a generic method with supplied type arguments
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static MethodInfo CloseGenericMethod(this MethodInfo src, params Type[] args)
            => src.GenericDefintion().MakeGenericMethod(args);

        /// <summary>
        /// Reifies generic source methods, which must be of parametric arity 1
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static IEnumerable<MethodInfo> CloseGenericMethods(this IEnumerable<MethodInfo> src, Type arg)
            => from def in src.GenericMethodDefinitions()
               select def.MakeGenericMethod(arg);

        /// <summary>
        /// Reifies generic source methods, which must be of parametric arity 2
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static IEnumerable<MethodInfo> CloseGenericMethods(this IEnumerable<MethodInfo> src, Type arg1, Type arg2)
            => from def in src.GenericMethodDefinitions()
               select def.MakeGenericMethod(arg1, arg2);

        /// <summary>
        /// Reifies generic source methods, which must be of parametric arity 3
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static IEnumerable<MethodInfo> CloseGenericMethods(this IEnumerable<MethodInfo> src, Type arg1, Type arg2, Type arg3)
            => from def in src.GenericMethodDefinitions()
               select def.MakeGenericMethod(arg1, arg2, arg3);

        /// <summary>
        /// Closes each 1-parameter generic methods over each supplied argument
        /// </summary>
        /// <param name="src"></param>
        /// <param name="args"></param>
        public static IEnumerable<MethodInfo> CloseGenericMethods(this IEnumerable<MethodInfo> src, Type[] args)
            => from def in src.GenericMethodDefinitions()
                from arg in args
                select def.MakeGenericMethod(arg);

        /// <summary>
        /// Selects generic methods from a stream that have a specified generic type definition parameter
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="typedef">The type definition to match</param>
        public static IEnumerable<MethodInfo> WithGenericParameterType(this IEnumerable<MethodInfo> src, Type typedef)
            => src.Where(m => m.GetParameters().Any(
                    p => p.ParameterType.IsGenericTypeDefinition && p.ParameterType == typedef));

        /// <summary>
        /// If a method is non-generic, returns an emtpy list.
        /// If a method is open generic, returns a list describing the open parameters
        /// If a method is closed generic, returns a list describing the closed parameters
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="effective">Whether to yield effective types or types as reported by the framework reflection api</param>
        public static Type[] GenericParameters(this MethodInfo m, bool effective)
        {
            var dst = new Type[]{};
            if((!m.IsGenericMethod && !m.IsGenericMethodDefinition))
                return dst;
            else return 
                (m.IsConstructedGenericMethod 
                ? m.GetGenericArguments() 
                : m.GetGenericMethodDefinition().GetGenericArguments()).Select(arg => effective ? arg.EffectiveType() : arg).ToArray();                             
        }

        /// <summary>
        /// For a non-constructed generic method or a generic method definition, returns an array of the method's type parameters; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] OpenTypeParameters(this MethodInfo m, bool effective)
            => (m.ContainsGenericParameters ? m.GetGenericMethodDefinition().GetGenericArguments()
             : m.IsGenericMethodDefinition ? m.GetGenericArguments()
             : new Type[]{}).Select(arg => effective ? arg.EffectiveType() : arg).ToArray();

        /// <summary>
        /// For a closed generic method, returns the supplied arguments; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="effective">Whether to yield effective types or types as reported by the framework reflection api</param>
        public static Type[] SuppliedTypeArgs(this MethodInfo m, bool effective = true)
            => m.IsConstructedGenericMethod ? m.GenericParameters(effective) : new Type[]{};



    }
}