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

    partial class XReflex
    {
        [MethodImpl(Inline), Op]
        public static Type[] NonPublicTypes(this Assembly a)
            => a.Types().NonPublic();
    }
}