//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static ReflectionFlags;

    partial class Memories
    {
        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="name">The name of the method</param>    
        /// <typeparam name="T">The type to search</typeparam>
        /// <typeparam name="A1">The first argument type</typeparam>
        /// <typeparam name="A2">The second argument type</typeparam>
        [MethodImpl(Inline)]
        public static Option<MethodInfo> method<T,X,R>(string name)
            => typeof(T).MatchMethod(name, typeof(X), typeof(R));

        /// <summary>
        /// Searches a type for an instance constructor that matches a specified signature
        /// </summary>
        /// <param name="declaring">The type to search</param>
        /// <param name="args">The method parameter types in ordinal position</param>
        [MethodImpl(Inline)]
        public static Option<ConstructorInfo> ctor(Type declaring, params Type[] args)
            => declaring.GetConstructor(BF_Instance, null, args, array<ParameterModifier>());

        /// <summary>
        /// Searches a type for an instance constructor that matches a specified signature
        /// </summary>
        /// <param name="args">The method parameter types in ordinal position</param>
        /// <typeparam name="T">The type to search</typeparam>
        [MethodImpl(Inline)]
        public static Option<ConstructorInfo> ctor<T>(params Type[] args)
            => ctor(typeof(T), args);
    }
}