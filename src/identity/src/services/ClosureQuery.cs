//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct ClosureQuery
    {
        public static Type[] numeric(MethodInfo m)
            => from c in ClosureKinds.numeric(m)
               let t = c.SystemType()
               where t != typeof(void)
               select t;
    }
}