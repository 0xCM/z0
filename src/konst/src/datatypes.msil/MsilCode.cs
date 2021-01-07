//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MsilCode
    {
        public CliSig Sig {get;}

        public Index<byte> Data {get;}

        [MethodImpl(Inline)]
        public MsilCode(CliSig sig, Index<byte> data)
        {
            Sig = sig;
            Data = data;
        }
    }
}