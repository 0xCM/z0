//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IIndexedView<T> : ILengthwise
    {
        ref readonly T Lookup(int index);

        ref readonly T this[int index] 
            => ref Lookup(index);                
    }
    
    public interface IIndexedView<E,T> : IIndexedView<T>
        where E : unmanaged, Enum
    {
        ref readonly T Lookup(E index);

        ref readonly T this[E index] 
            => ref Lookup(index);        

        ref readonly T IIndexedView<T>.Lookup(int index)            
            => ref Lookup(Root.literal<E>(index));
    }
}