//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class Root
    {
        /// <summary>
        /// Returns true if the test operand is not null
        /// </summary>
        /// <param name="test">The object to test for nullity</param>
        [MethodImpl(Inline)]
        public static bool notnull(object test)
            => test != null;
    }
}