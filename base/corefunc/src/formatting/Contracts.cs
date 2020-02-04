//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Identifies format configurations
    /// </summary>
    public interface IFormatConfig
    {
        
    }

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
    }

    /// <summary>
    /// Characterizes a strongly-typed formatter
    /// </summary>
    public interface IFormatter<T> : IFormatter
    {

        /// <summary>
        /// Renders an object as text
        /// </summary>
        /// <param name="src">The source object</param>
        string Format(T src);


        /// <summary>
        /// Default untyped implemntation predicated on a typed implementation
        /// </summary>
        /// <param name="src">The source object</param>
        [MethodImpl(Inline)]
        string IFormatter.Format(object src)
            => Format(src);
    }


    /// <summary>
    /// Identifies formattable things to prevent excluding extant "Format" extension methods 
    /// that are independent of the formatting onfrastructure
    /// </summary>
    public interface ICustomFormattable
    {

    }

    /// <summary>
    /// Characterizes a configurable formatter
    /// </summary>
    public interface IConfiguredFormatter : IFormatter
    {
        /// <summary>
        /// Formats a source object using a specified configuration
        /// </summary>
        /// <param name="src">The source object</param>
        /// <param name="config">The format configuration</param>
        string Format(object src, IFormatConfig config);
    }

    /// <summary>
    /// Characterizes a strongly-typed configurable formatter
    /// </summary>
    public interface IConfiguredFormatter<T> : IConfiguredFormatter, IFormatter<T>
    {
        /// <summary>
        /// Formats a source object using a specified configuration
        /// </summary>
        /// <param name="src">The source object</param>
        /// <param name="config">The format configuration</param>
        string Format(T src, IFormatConfig config);

        /// <summary>
        /// Default untyped implemntation predicated on a typed implementation
        /// </summary>
        /// <param name="src">The source object</param>
        [MethodImpl(Inline)]
        string IFormatter.Format(object src)
            => Format(src);

        /// <summary>
        /// Default untyped implemntation predicated on a typed implementation
        /// </summary>
        /// <param name="src">The source object</param>
        /// <param name="configuration">The format configuration</param>
        [MethodImpl(Inline)]
        string IConfiguredFormatter.Format(object src, IFormatConfig config)
            => Format(src, config);
    }

    /// <summary>
    /// Applied to a type to specify a non-default formatter
    /// </summary>
    public class FormatterAttribute : Attribute
    {        
        public FormatterAttribute(Type realization)
            => this.Realization = realization;

        /// <summary>
        /// Specifies the type that realizes IFormatter and its generic variants if extant
        /// </summary>
        public Type Realization {get;}
    }

}