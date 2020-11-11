// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(string src)
            => z.address(z.pchar(src));
    }
}