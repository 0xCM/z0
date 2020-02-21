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
    /// Base formatter interface
    /// </summary>
    public interface IFormatter
    {

    }

    /// <summary>
    /// Characterizes a strongly-typed formatter
    /// </summary>
    public interface IFormatter<T> : IObjectFormatter
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
        string IObjectFormatter.Format(object src)
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