//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial class XTend
    {
        [TextUtility]
        public static StringBuilder Line(this StringBuilder sb, char c)
        {
            sb.AppendLine(c.ToString());
            return sb;
        }
    }
}