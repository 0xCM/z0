//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EncodedOpCode
    {
        readonly ulong Data;

        public static implicit operator EncodedOpCode(ulong data)
            => new EncodedOpCode(data);

        [MethodImpl(Inline)]
        public EncodedOpCode(ulong data)
        {
            Data = data;
        }        
    }
}