//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    [ApiHost("api")]
    public partial class BitFields : IApiHost<BitFields>
    {
        [MethodImpl(Inline)]
        public static BitField64<E> bf64<E>(E state)
            where E : unmanaged, Enum
                => BitField64<E>.Define(state);        
    }
}