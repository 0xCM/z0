//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a text serializer
    /// </summary>
    public interface IFormatter
    {
        /// <summary>
        /// Renders an object as text
        /// </summary>
        /// <param name="src">The source object</param>
        string Format(object src);
    }

    /// <summary>
    /// Characterizes a type-parametric formatter
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
        string IFormatter.Format(object src)
            => Format(src);
    } 
    
    /// <summary>
    /// Characterizes a configurable formatter, parametric in both type and configuration
    /// </summary>
    public interface IFormatter<T,C> : IFormatter<T>
        where C : struct
    {
        /// <summary>
        /// Formats a source value according to a supplied configuration
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="config">The configuration</param>
        string Format(T src, in C config);
        
    }    
}