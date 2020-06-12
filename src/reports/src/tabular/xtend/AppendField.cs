//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        public static void AppendField<C,F>(this StringBuilder sb, F field, C content, char delimiter)
            where C : ITextual
            where F : unmanaged, Enum
        {
            var pad = Tabular.width(field);
            sb.Append($"{delimiter} ");            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void AppendField<C,F>(this StringBuilder sb, F field, C content)
            where C : ITextual
            where F : unmanaged, Enum
        {            
            var pad = Tabular.width(field);
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void AppendField<F>(this StringBuilder sb, F field, object content)
            where F : unmanaged, Enum
        {            
            var pad = Tabular.width(field);
            sb.Append($"{content?.ToString()}".PadRight(pad));
        }

        public static void AppendHeader<F>(this StringBuilder sb, char delimiter)
            where F : unmanaged, Enum
        {            
            var fields = Tabular.fields<F>();
            for(var i=0; i<fields.Length; i++)
            {
                var field = fields[i];
                var width = Tabular.width(field);
                if(i != 0)
                {
                    sb.Append(Chars.Space);
                    sb.Append(delimiter);
                    sb.Append(Chars.Space);
                }

                sb.Append(field.ToString().PadRight(width));
            }
        }

        public static void AppendField<F>(this StringBuilder sb, F field,  object content, char delimiter)
            where F : unmanaged, Enum
        {            
            var pad = Tabular.width(field);
            sb.Append($" {delimiter} ");            
            sb.Append($"{content?.ToString()}".PadRight(pad));
        }
    }
}