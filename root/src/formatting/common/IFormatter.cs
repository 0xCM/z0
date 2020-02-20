//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    /// <summary>
    /// Characterizes a type that transforms objects to a text-based representation
    /// </summary>
    public interface IFormatter
    {
        /// <summary>
        /// Renders an object as text
        /// </summary>
        /// <param name="src">The source object</param>
        string Format(object src);

        /// <summary>
        /// Formats a source object using a specified configuration
        /// </summary>
        /// <param name="src">The source object</param>
        /// <param name="config">The format configuration</param>
        [MethodImpl(Inline)]
        string Format(object src, IFormatConfig config)
            => Format(src);
    }

    /// <summary>
    /// Characterizes a strongly-typed formatter
    /// </summary>
    public interface IFormatter<T> : IFormatter
    {
        /// <summary>
        /// Renders an object as text
        /// </summary>
        /// <param name="src">The source value</param>
        string Format(T src);

        /// <summary>
        /// Default untyped implemntation predicated on a typed implementation
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        string IFormatter.Format(object src)
            => Format(src);

        /// <summary>
        /// Renders a source value according to a supplied configuration
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="config">The configuration</param>
        /// <typeparam name="C">The configuration type</typeparam>
        [MethodImpl(Inline)]
        string Format<C>(T src, C config)
            where C : IFormatConfig
                => Format(src);            
    }

}