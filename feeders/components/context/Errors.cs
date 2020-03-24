//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Unsupported
    {
        /// <summary>
        /// Populates a <see cref="NotSupportedException"/> complaining that a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static NotSupportedException error<T>()
            => new NotSupportedException($"The type {typeof(T).Name} is not supported in the current context");

        /// <summary>
        /// Populates a <see cref="NotSupportedException"/>, populated with a custom message describing why a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static NotSupportedException error<T>(string description)
            => new NotSupportedException($"Unsupported type: {typeof(T).Name}: {description}");

        /// <summary>
        /// Raises <see cref="NotSupportedException"/> complaining that a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static T raise<T>()
            => throw error<T>();

        /// <summary>
        /// Raises <see cref="NotSupportedException"/> populated with a custom message describing why a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static T raise<T>(string description)
            => throw error<T>();
    }
}