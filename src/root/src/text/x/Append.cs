//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    partial class XText
    {
        [TextUtility]
        public static void Append<T>(this StringBuilder builder, T content, Padding pad)
            where T : ITextual
        {
            builder.Append($"{content.Format()}".PadRight((int)pad));
        }
    }
}