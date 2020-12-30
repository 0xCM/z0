//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial class WfShell
    {
       [MethodImpl(Inline), Op]
        public static Assembly controller()
            => WfEnv.entry();

        [MethodImpl(Inline)]
        public static Assembly controller<A>()
            => typeof(A).Assembly;
    }
}