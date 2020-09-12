//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public delegate void HexReceiver<H>(H h)
        where H : unmanaged, IHexType;

    public readonly struct HexCodeSink<H> : IHexHandler<H>, IHexHandler
        where H:unmanaged, IHexType
    {
        static H Code => default;

        readonly HexReceiver<H> Receiver;

        [MethodImpl(Inline)]
        public HexCodeSink(HexReceiver<H> receiver)
        {
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void OnHex(Hex8Kind kind)
        {
            if(kind == Code.Value)
                OnHex(Code);
        }

        [MethodImpl(Inline)]
        public void OnHex(H h)
            => Receiver(h);
    }
}