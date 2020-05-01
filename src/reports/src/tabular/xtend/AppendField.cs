//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        public static void AppendDelimited<C,F>(this StringBuilder sb, C content, F field, char delimiter)
            where C : ITextual
            where F : unmanaged, Enum
        {
            var pad = FieldFormat.width(field);
            sb.Append($"{delimiter} ");            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void AppendField<C,F>(this StringBuilder sb, C content, F field)
            where C : ITextual
            where F : unmanaged, Enum
        {            
            var pad = FieldFormat.width(field);
            sb.Append($"{content?.Format()}".PadRight(pad));
        }
    }
}