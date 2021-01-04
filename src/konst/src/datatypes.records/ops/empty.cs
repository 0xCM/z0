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
    using static z;

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