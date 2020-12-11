//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Formats anything via <see cref='object.ToString()'/>
    /// </summary>
    public readonly struct DefaultTextFormatter : ITextFormatter<DefaultTextFormatter,object>
    {
        public static DefaultTextFormatter Service => default;

        [MethodImpl(Inline)]
        public string Format(object src)
            => src?.ToString() ?? "<null>";
    }
}