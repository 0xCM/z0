//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct AsmBlockHeader
    {
        public OpUri Uri;

        public string OpSig;

        public string DataProp;

        public MemoryAddress BaseAddress;


        [MethodImpl(Inline)]
        public AsmBlockHeader(OpUri uri, string sig, string prop, MemoryAddress @base)
        {
            Uri = uri;
            OpSig = sig;
            DataProp = prop;
            BaseAddress = @base;
        }
    }
}