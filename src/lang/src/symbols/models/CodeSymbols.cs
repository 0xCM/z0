//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class CodeSymbols : CodeSymbols<CodeSymbols,ICodeSymbol>, ICodeSymbols<ICodeSymbol>
    {
        public CodeSymbols()
        {

        }

        public CodeSymbols(uint count)
            : base(count)
        {

        }

        [MethodImpl(Inline)]
        public CodeSymbols(ICodeSymbol[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        internal ref readonly ICodeSymbol Lookup(uint index)
            => ref Data[index];

        public CodeSymbol this[uint index]
        {
            [MethodImpl(Inline)]
            get => new CodeSymbol(this,index);
        }
    }
}