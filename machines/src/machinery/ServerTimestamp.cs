//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct ServerTimestamp
    {
        [MethodImpl(Inline)]
        public static ulong Timestamp(uint ServerId = 0)        
            => (ulong)(now().Ticks - TimeOrigin.Ticks);                        

        static DateTime TimeOrigin => new DateTime(2019,01,01);        
    }
}