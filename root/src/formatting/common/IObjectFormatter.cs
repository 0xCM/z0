//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes a type that transforms objects to a text-based representation
    /// </summary>
    public interface IObjectFormatter : IFormatter
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
}