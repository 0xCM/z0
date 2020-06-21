//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an op code via a sequence bytes
    /// </summary>
    public readonly struct EncodedOpCode : ITextual
    {
        readonly ulong Data;

        public static implicit operator EncodedOpCode(ulong data)
            => new EncodedOpCode(data);

        [MethodImpl(Inline)]
        public EncodedOpCode(ulong data)
        {
            Data = data;
        }       

        public string Format()
            => asci.format(Data);

        public override string ToString() 
            => Format();
    }
}