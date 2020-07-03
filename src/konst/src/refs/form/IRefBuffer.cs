//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IRefBuffer : IRef
    {
        ref byte Cell(int index);

        ref byte this[int index]
            => ref Cell(index);
    }
    
    public interface IRefBuffer<T> : IRefBuffer
    {
        Span<S> As<S>();                

        new ref T Cell(int index);

        ref byte IRefBuffer.Cell(int index)
            => ref Unsafe.As<T,byte>(ref Cell(index));
        
        uint IRef.CellSize
            => (uint)Unsafe.SizeOf<T>();
        
        new ref T this[int index]
            => ref Cell(index);
    }

}