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

    using static Root;
    using static ReflectionFlags;
    
    partial class RootReflections
    {
        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this MemberInfo m) 
            where A : Attribute
                => m.GetCustomAttribute<A>();

        /// <summary>
        /// Determines whether a method has a speicied arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        public static bool HasArity(this MethodInfo m, int arity)
            => m.Arity() == arity;

        /// <summary>
        /// Determines whether the method is an implicit conversion operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsImplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Implicit", IgnoreCase);

        /// <summary>
        /// Determines whether the method is an explicit conversion operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsExplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Explicit", IgnoreCase);

        /// <summary>
        /// Determines whether a method is an implict or explicit conversion operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsConversionOp(this MethodInfo m)
            => m.IsExplicitConverter() || m.IsImplicitConverter();

        /// <summary>
        /// Determines the number of parameters defined by a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static int Arity(this MethodInfo m)
            => m.GetParameters().Length;

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ParameterTypes(this MethodInfo m)
            => m.GetParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ParameterTypes(this MethodInfo m, bool effective)
            => effective ? m.ParameterTypes().Select(t => t.EffectiveType()) : m.ParameterTypes();

        /// <summary>
        /// Determines the type of an index-identified parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="index">The parameter index</param>
        public static Type ParameterType(this MethodInfo m, int index)
            => m.Arity() >= index + 1 ? m.GetParameters()[index].ParameterType : typeof(void);

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ImmediateParameters(this MethodInfo m)
            => m.GetParameters().Where(p => p.Tagged<ImmAttribute>()).Select(p => p.ParameterType);
   }
}