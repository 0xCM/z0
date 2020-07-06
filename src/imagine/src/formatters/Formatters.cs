//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiHost]
    public readonly partial struct Formatters
    {        
        /// <summary>
        /// Reifies a formatter via Object.ToString()
        /// </summary>
        readonly struct DefaultFormatter : IFormatter
        {
            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? string.Empty;
        }
    }
}