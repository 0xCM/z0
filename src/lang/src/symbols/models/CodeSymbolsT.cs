//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class CodeSymbols<T> : CodeSymbols<CodeSymbols<T>,T>, ICodeSymbols<T>
        where T : ICodeSymbol
    {
        public CodeSymbols()
        {

        }

        public CodeSymbols(uint count)
            : base(count)
        {

        }

        [MethodImpl(Inline)]
        public CodeSymbols(T[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        internal ref readonly T Lookup(uint index)
            => ref Data[index];

        public CodeSymbol<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => new CodeSymbol<T>(Data[index]);
        }
    }
}