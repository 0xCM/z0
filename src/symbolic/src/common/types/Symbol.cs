//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Symbol : ISymbol
    {
        readonly ushort Data;

        [MethodImpl(Inline)]
        internal Symbol(ushort data)
            => this.Data = data;
        
        public char Value
        {
            [MethodImpl(Inline)]
            get => (char)Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => $"{Value}";

        public override string ToString()
            => Format();            
    }
}