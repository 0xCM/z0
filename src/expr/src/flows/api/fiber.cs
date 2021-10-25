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
        [MethodImpl(Inline)]
        public static Fiber<T> fiber<T>(T channel, uint cell = 0, ushort offset = 0, byte width = 0)
            where T : unmanaged,IChannel
                => new Fiber<T>(channel,cell,offset,width);

        [MethodImpl(Inline), Op]
        public static Fiber fiber(Channel channel, uint cell = 0, ushort offset = 0, byte width = 0)
            => new Fiber(channel,cell,offset,width);
    }
}