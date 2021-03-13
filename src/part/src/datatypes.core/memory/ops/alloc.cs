//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static T[] alloc<T>(uint count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline)]
        public static T[] alloc<T>(long count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline)]
        public static T[] alloc<T>(ulong count)
            => sys.alloc<T>(count);
    }
}