//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class root
    {                
        [MethodImpl(Inline)]
        public static Factory<T> factory<T>()
            => default;
    }
}