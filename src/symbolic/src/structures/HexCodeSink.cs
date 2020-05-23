//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public delegate void HexReceiver<H>(H h)
        where H :unmanaged, IHexCode;

    public readonly struct HexCodeSink<H> : IHexHandler<H>, IHexHandler
        where H :unmanaged, IHexCode
    {
        static H Code => default;

        readonly HexReceiver<H> Receiver;
        
        [MethodImpl(Inline)]
        public HexCodeSink(HexReceiver<H> receiver)
        {
            Receiver = receiver;
        }
        
        [MethodImpl(Inline)]
        public void OnHex(HexKind kind)
        {
            if(kind == Code.Kind)
                OnHex(Code);
        }

        [MethodImpl(Inline)]
        public void OnHex(H h)
            => Receiver(h);
    }
}