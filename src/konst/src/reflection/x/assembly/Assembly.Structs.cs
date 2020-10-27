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
        public static Type[] Structs(this Assembly a)
            => a.Types().Structs();
    }
}