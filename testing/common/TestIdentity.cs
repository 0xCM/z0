//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public static class TestIdentityX
    {
        public static string TestCaseName(this IExplicitTest unit)
        {
            var owner = TypeIdentity.owner(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "explicit";
            return $"{owner}/{hostname}/{opname}";
        }

        public static string TestActionName(this IUnitTest unit)
        {
            var owner = TypeIdentity.owner(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "action";
         
            return $"{owner}/{hostname}/{opname}";
        }
    }
}