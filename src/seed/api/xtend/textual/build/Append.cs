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
        public static void Append<T>(this StringBuilder sb, T content, Padding pad)
            where T : ITextual             
        {
            sb.Append($"{content.Format()}".PadRight((int)pad));
        }
        
        public static void Append<F,T>(this StringBuilder sb, F field, T content)
            where F : unmanaged, Enum
            where T : ITextual             
        {            
            sb.Append($"{content.Format()}".PadRight(text.padding(field)));
        }

        public static void Append<F>(this StringBuilder sb, F field, object content)
            where F : unmanaged, Enum
        {
            sb.Append($"{content}".PadRight(text.padding(field)));
        }
    }
}