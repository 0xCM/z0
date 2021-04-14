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
    using static memory;

    partial class text
    {
        [Op]
        public static StringReader reader(string src)
            => new StringReader(src);
    }
}