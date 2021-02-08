//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpContent : IAsmOpContent<DataWidth,BinaryCode>
    {
        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public AsmOpContent(BinaryCode data)
        {
            Data = data;
        }

        public DataWidth Width
        {
            [MethodImpl(Inline)]
            get => (DataWidth)(Data.Count * 8);
        }
    }
}