//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;


    using static Konst;

    partial struct Cil
    {
        public readonly struct OpCodeSymbol
        {
            public readonly Symbol<ILOpCode,ushort,N16> Value;

            [MethodImpl(Inline)]
            public static implicit operator OpCodeSymbol(ILOpCode src)
                => new OpCodeSymbol(src);

            [MethodImpl(Inline)]
            public OpCodeSymbol(ILOpCode src)
            {
                Value = new Symbol<ILOpCode, ushort, N16>(src);
            }

            [MethodImpl(Inline)]
            public OpCodeSymbol(Symbol<ILOpCode, ushort, N16> src)
            {
                Value = src;
            }
        }
    }
}