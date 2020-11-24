//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CilOpCodeSymbol
    {
        public Symbol<ILOpCode,ushort,N16> Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator CilOpCodeSymbol(ILOpCode src)
            => new CilOpCodeSymbol(src);

        [MethodImpl(Inline)]
        public CilOpCodeSymbol(ILOpCode src)
            => Value = new Symbol<ILOpCode,ushort,N16>(src);

        [MethodImpl(Inline)]
        public CilOpCodeSymbol(Symbol<ILOpCode,ushort,N16> src)
            => Value = src;
    }
}