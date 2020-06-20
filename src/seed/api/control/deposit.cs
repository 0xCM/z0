// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe int deposit<T>(T* pSrc, int count, Span<T> dst)
            where T : unmanaged
                => PointedReader.Create<T>(pSrc, count).Read(0,count,dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe int deposit<T>(T* pSrc, int count, ref T dst)
            where T : unmanaged
                => PointedReader.Create<T>(pSrc, count).Read(0,count, ref dst);
    }
}