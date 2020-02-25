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

    public interface IConfigurableFormatter : IFormatter
    {
        /// <summary>
        /// Formats a source value according to a supplied configuration
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="config">The configuration</param>
        [MethodImpl(Inline)]
        string Format(object src, IFormatConfig config)
            => Format(src);
    }

    public interface IConfigurableFormatter<C> : IConfigurableFormatter
        where C : IFormatConfig
    {
        /// <summary>
        /// Formats a source value according to a supplied configuration
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="config">The configuration</param>
        string Format(object src, in C config);

        [MethodImpl(Inline)]
        string IConfigurableFormatter.Format(object src, IFormatConfig config)
            => Format(src, (C)config);
    }
}