//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    partial class XTend
    {        
        public static StringBuilder Build(this string src)
            => new StringBuilder(src);
    }
}