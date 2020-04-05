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
        public static void AppendField<T>(this StringBuilder sb, object content, T pad)
            where T : unmanaged, Enum
        {                        
            sb.Append($"{content}".PadRight(EnumFormatter.numeric<T,int>(pad)));
        }

        public static void AppendField<F>(this StringBuilder sb, F content, int pad)
            where F : ICustomFormattable
        {            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

        public static void AppendField(this StringBuilder sb, object content)
        {
            sb.Append($"{content}");
        }

        public static void AppendField(this StringBuilder sb, object content, int pad)
        {            
            sb.Append($"{content}".PadRight(pad));
        }


    }
}