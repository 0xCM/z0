//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static ReflectionFlags;

    partial struct Clr
    {
        /// <summary>
        /// Searches a type for an instance constructor that matches a specified signature
        /// </summary>
        /// <param name="declaring">The type to search</param>
        /// <param name="args">The method parameter types in ordinal position</param>
        [MethodImpl(Inline), Op]
        public static Option<ConstructorInfo> ctor(Type declaring, params Type[] args)
            => declaring.GetConstructor(BF_Instance, null, args, sys.empty<ParameterModifier>());

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