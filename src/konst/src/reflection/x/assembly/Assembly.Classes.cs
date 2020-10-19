//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static Type[] Classes(this Assembly a)
            => a.Types().Classes();

        [MethodImpl(Inline), Op]
        public static Type[] Classes(this Assembly a, string name)
            => a.Classes().Where(c => c.Name == name);
    }
}