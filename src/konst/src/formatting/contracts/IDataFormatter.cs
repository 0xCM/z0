//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a configurable formatter, parametric in both type and configuration
    /// </summary>
    public interface IDataFormatter<C,T> : IFormatter<T>
        where C : struct
    {
        /// <summary>
        /// Formats a source value according to a supplied configuration
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="config">The configuration</param>
        string Format(T src, in C config);  

        [MethodImpl(Inline)]
        string IFormatter<T>.Format(T src)
            => Format(src, default);              
    }    
}