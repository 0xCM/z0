//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XReflex
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo[] Fields(this Assembly a)
            => a.GetTypes().SelectMany(x => x.Fields()).ToArray();
    }
}