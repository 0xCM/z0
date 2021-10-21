//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    partial struct strings
    {
        [Op, Closures(Closure)]
        public static StringBuffer<S> buffer<S>(uint length)
            where S : unmanaged
                => new StringBuffer<S>(length);

        [Op, Closures(Closure)]
        public static StringBuffer<S> buffer<S>(int length)
            where S : unmanaged
                => new StringBuffer<S>(length);

        [Op, Closures(Closure)]
        public static StringBuffer buffer(uint length)
            => new StringBuffer(length);

        [Op, Closures(Closure)]
        public static StringBuffer buffer(int length)
            => new StringBuffer(length);
    }
}