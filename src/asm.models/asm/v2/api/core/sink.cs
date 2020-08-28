//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static HexCodeSink<H> sink<H>(HexReceiver<H> receiver)
            where H:unmanaged, IHexType
                => new HexCodeSink<H>(receiver);
    }

}