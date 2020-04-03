//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class BlockedType
    {
        /// <summary>
        /// Determines whether a type is block-classified
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
            => tag(t) != null;

    }
}