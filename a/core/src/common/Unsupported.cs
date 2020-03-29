//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class Unsupported
    {
        /// <summary>
        /// Populates a <see cref="NotSupportedException"/> complaining that a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static NotSupportedException define<T>()
            => new NotSupportedException($"The type {typeof(T).Name} is not supported in the current context");

        /// <summary>
        /// Populates a <see cref="NotSupportedException"/>, populated with a custom message describing why a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static NotSupportedException define<T>(string description)
            => new NotSupportedException($"Unsupported type: {typeof(T).Name}: {description}");

        /// <summary>
        /// Populates a <see cref="NotSupportedException"/> complaining that a specified numeric kind isn't supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static NotSupportedException define(NumericKind k)
            => new NotSupportedException($"The type {k.Format()} is not supported in the current context");

        public static T define<S,T>(S src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Unsupported.raise<T>($"The conversion {typeof(S).Name} -> {typeof(T).Name} needed for the value {src} doesn't exist {caller} ,{file},{line}");

        /// <summary>
        /// Raises <see cref="NotSupportedException"/> complaining that a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static T raise<T>()
            => throw define<T>();

        /// <summary>
        /// Raises <see cref="NotSupportedException"/> populated with a custom message describing why a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        public static T raise<T>(string description)
            => throw define<T>();
    }
}