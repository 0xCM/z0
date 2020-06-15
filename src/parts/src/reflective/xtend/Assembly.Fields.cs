//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    partial class XTend
    {
        public static FieldInfo[] Fields(this Assembly a)
            => a.GetTypes().SelectMany(x => x.DeclaredFields()).ToArray();
    }
}