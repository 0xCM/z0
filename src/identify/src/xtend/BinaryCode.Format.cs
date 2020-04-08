//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
 
    partial class XTend
    {    
        public static string Format(this BinaryCode src)
            => HexFormat.data(src.Bytes);
    }
}