//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class text
    {
        [Op]
        public static TextTraverser traverse(string src)
            => new TextTraverser(src);
    }
}