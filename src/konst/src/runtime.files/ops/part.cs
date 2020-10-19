//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        public static PartId part(FileName src)
        {
            var i = src.Name.Text.IndexOf(Chars.Dot);
            if(i == NotFound)
                return default;
            else
                return ApiPartIdParser.single(text.segment(src.Name.Text,0, i - 1));
        }
    }
}