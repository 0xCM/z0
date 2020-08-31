//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    public interface ISpan : IMeasured, INullity
    {        
        Span<byte> Bytes {get;}

        void Clear();
    }    

    public interface ISpan<T> : ISpan
        where T : struct
    {
        ref T Cell(int index);

        ref T this[int index] {get;}

        Span<T> Slice(int offset);

        Span<T> Slice(int offset, int length);   
        
        ref T GetPinnableReference();             
    }    
    
    public interface ISpan<F,T> : ISpan<T>, IReified<F>, INullary<F,T>
        where F : struct, ISpan<F,T>
        where T : struct
    {
        Span<T> Data {get;}
        
        Span<byte> ISpan.Bytes
            => MemoryMarshal.AsBytes(Data);

        void ISpan.Clear()
            => Data.Clear();

        Span<T>.Enumerator GetEnumerator()
            => Data.GetEnumerator();

        Span<T> ISpan<T>.Slice(int offset)
            => Data.Slice(offset);

        ref T ISpan<T>.GetPinnableReference()     
            => ref Data.GetPinnableReference();

        Span<T> ISpan<T>.Slice(int offset, int length)
            => Data.Slice(offset, length);

        bool INullity.IsEmpty 
            => Data.Length == 0;

        ref T ISpan<T>.this[int index]
            => ref Data[index];

        ref T ISpan<T>.Cell(int index) 
            => ref this[index];

        int IMeasured.Length 
            => Data.Length;
    }    
}