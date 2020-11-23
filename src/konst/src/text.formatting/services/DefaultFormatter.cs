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
    /// Formats anything via <see cref='object.ToString()'/>
    /// </summary>
    public readonly struct DefaultFormatter : ITextFormatter<DefaultFormatter,object>
    {
        public static DefaultFormatter Service => default;

        [MethodImpl(Inline)]
        public string Format(object src)
            => src?.ToString() ?? "<null>";
    }
}