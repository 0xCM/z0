//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline)]
        public static EmptyRecord<T> empty<T>()
            => default;

        [MethodImpl(Inline)]
        public static EmptyRecord empty()
            => default;
    }
}