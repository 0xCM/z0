//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines primary api for negotiating bitfields predicated on enumerations
    /// </summary>
    public static class BitField
    {
        public static BitField<T> Define<T>(ulong data)
            where T : unmanaged, Enum
                => BitField<T>.Define(data);
    }

}