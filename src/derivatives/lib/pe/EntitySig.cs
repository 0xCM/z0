//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ImageTables
    {
        public readonly struct EntitySig
        {
            public readonly byte[] Data;

            [MethodImpl(Inline)]
            public static implicit operator EntitySig(byte[] src)
                => new EntitySig(src);

            [MethodImpl(Inline)]
            public EntitySig(byte[] src)
            {
                Data = src;
            }
        }
    }
}