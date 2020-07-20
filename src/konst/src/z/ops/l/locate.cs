// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe ulong locate<T>(in T src)
            => (ulong)pvoid(src);

    }
}