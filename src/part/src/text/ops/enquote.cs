//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        [ Op]
        public static string enquote(string src)
        {
            if(!string.IsNullOrWhiteSpace(src))
                return TextFormat.concat(Chars.Quote, src, Chars.Quote);
            else
                return EmptyString;
        }
   }
}