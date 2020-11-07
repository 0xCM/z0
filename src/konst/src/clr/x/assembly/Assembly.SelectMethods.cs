//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    partial class XClrQuery
    {
        /// <summary>
        /// Selects the methods from an assembly that satisfy a specified predicate
        /// </summary>
        /// <param name="src">The source assembly</param>
        /// <param name="pred">The adjudicating predicate</param>
        [Op]
        public static MethodInfo[] SelectMethods(this Assembly src, Func<MethodInfo,bool> pred)
            => src.Types().Methods().Where(pred);
    }
}