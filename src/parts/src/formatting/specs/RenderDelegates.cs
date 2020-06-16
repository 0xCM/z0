//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an unconfigured content render function
    /// </summary>
    /// <param name="src">The content value</param>
    /// <typeparam name="T">The content type</typeparam>
    public delegate string FormatRender<T>(T src);

    /// <summary>
    /// Characterizes a configured content render function
    /// </summary>
    /// <param name="src">The content value</param>
    /// <param name="config">The configuration value</param>
    /// <typeparam name="C">THe configuration type</typeparam>
    /// <typeparam name="T">The content type</typeparam>
    public delegate string FormatRender<C,T>(T src, in C config)
        where C : struct;

    /// <summary>
    /// Characterizes a title render function
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The type for which titles will be provided</typeparam>
    public delegate string TitleRender<T>(T src);
}