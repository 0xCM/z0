//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {

        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => As.generic<T>(src);
    }
}