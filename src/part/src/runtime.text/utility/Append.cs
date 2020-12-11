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
        public static void Append<T>(this StringBuilder sb, T content, Padding pad)
            where T : ITextual
        {
            sb.Append($"{content.Format()}".PadRight((int)pad));
        }
    }
}