//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cil
    {
        public readonly struct OpCodeSymbol : ISymbol<Symbol<ILOpCode,ushort,N16>>
        {
            public Symbol<ILOpCode,ushort,N16> Value {get;}

            [MethodImpl(Inline)]
            public OpCodeSymbol(ILOpCode src)
                => Value = new Symbol<ILOpCode,ushort,N16>(src);

            [MethodImpl(Inline)]
            public OpCodeSymbol(Symbol<ILOpCode,ushort,N16> src)
                => Value = src;

            [MethodImpl(Inline)]
            public static implicit operator ILOpCode(OpCodeSymbol src)
                => src.Value.Value;

            [MethodImpl(Inline)]
            public static implicit operator OpCodeSymbol(ILOpCode src)
                => new OpCodeSymbol(src);

            [MethodImpl(Inline)]
            public static implicit operator OpCodeSymbol(OpCodeValue src)
                => new OpCodeSymbol((ILOpCode)src);

            public string Format()
                => Value.Value.ToString();
        }
    }
}