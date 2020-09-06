//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        /// <summary>
        /// Creates an index over the known parts
        /// </summary>
        public static PartIndex index()
            => index(modules().Parts);
    }
}