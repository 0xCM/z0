//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct EncodedOpCode
    {
        readonly ulong Data;

        public static implicit operator EncodedOpCode(ulong data)
            => new EncodedOpCode(data);

        [MethodImpl(Inline)]
        public EncodedOpCode(ulong data)
        {
            this.Data = data;
        }        
    }
}