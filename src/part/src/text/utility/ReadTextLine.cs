//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    partial class XText
    {
        [MethodImpl(Inline), Op]
        public static TextLine ReadTextLine(this StreamReader src, uint number)
            => new TextLine(number, src.ReadLine());
    }
}