//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using API = Symbolic;

    public readonly struct Symbol<E,T> : ISymbol<Symbol<E,T>,E,T>
        where E : unmanaged, Enum
        where T : unmanaged         
    {
        public T Data {get;}
                
        public E Value 
        {
            [MethodImpl(Inline)]
            get => Enums.literal<E,T>(Data);
        }

        [MethodImpl(Inline)]
        internal Symbol(T src)
        {
            Data = src;
        }        

        char ISymbol.Value 
        {
            [MethodImpl(Inline)]
            get => API.@char(this);
        }        
    }
}