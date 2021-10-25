//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct flows
    {
        [MethodImpl(Inline), Op]
        public static Channel channel(uint cells, uint width, Mask mask = default)
            => new Channel(cells,width,mask);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Channel<T> channel<T>(uint cells, Mask mask = default)
            where T : unmanaged, ITypeWidth
                => new Channel<T>(cells,mask);

        [MethodImpl(Inline)]
        public static Channel<N,W> channel<N,W>(N n = default, W w = default)
            where W : unmanaged, ITypeWidth
            where N : unmanaged, ITypeNat
                => new Channel<N,W>();

        [MethodImpl(Inline)]
        public static Channel<N,W> channel<N,W>(Mask mask, N n = default, W w = default)
            where W : unmanaged, ITypeWidth
            where N : unmanaged, ITypeNat
                => new Channel<N,W>(mask);
    }
}