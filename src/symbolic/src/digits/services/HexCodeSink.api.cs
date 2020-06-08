//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public class HexCodeSink
    {
        [MethodImpl(Inline)]
        public static HexCodeSink<H> Create<H>(HexReceiver<H> receiver)
            where H :unmanaged, IHexCode
                => new HexCodeSink<H>(receiver);
    }
}