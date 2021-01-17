// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Location<T> location<T>(T src)
            where T : struct
                => new Location<T>(src);
    }
}