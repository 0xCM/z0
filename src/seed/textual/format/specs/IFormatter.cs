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
}