//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    partial class XTend
    {
        public static StringBuilder WithLabel(this StringBuilder sb, object label, object content)
        {
            sb.Append($"{label}".PadRight(12));
            sb.Append($"{content}");
            sb.AppendLine();
            return sb;
        }

        public static StringBuilder AppendLine(this StringBuilder sb, char c)
        {
            sb.AppendLine(c.ToString());
            return sb;
        }
    }
}