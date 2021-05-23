//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct AsmCoreModels
    {
        public readonly struct Decoded
        {
            public AsmHexCode Data {get;}

            [MethodImpl(Inline)]
            public Decoded(AsmHexCode data)
            {
                Data = data;
            }
        }
    }
}