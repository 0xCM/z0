//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Symbol<E> : ISymbol<Symbol<E>,E>
        where E : unmanaged, Enum
    {
        readonly ulong Data;
        
        [MethodImpl(Inline)]
        public static implicit operator Symbol(Symbol<E> src)    
            => new Symbol((ushort)src.Data);
        
        public E Value 
        {
            [MethodImpl(Inline)]
            get => Enums.literal<E,ulong>(Data);
        }

        [MethodImpl(Inline)]
        internal Symbol(ulong src)
        {
            Data = src;
        }        

        char ISymbol.Value 
        {
            [MethodImpl(Inline)]
            get => (char)Data;
        }        
    }
}