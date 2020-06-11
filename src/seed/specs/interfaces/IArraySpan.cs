//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISpan : ILengthwise, INullaryKnown
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
    
    public interface ISpanEnumerator
    {
        bool MoveNext();

        bool HasNext {get;}        
    }

    public interface ISpanEnumerator<T> : ISpanEnumerator
    {
        ref T Current {get;}
    }

    public interface ISpanEnumerator<F,T> : ISpanEnumerator<T>
        where F : struct, ISpanEnumerator<F,T>
    {

    }

    public interface ISpan<F,T> : ISpan<T>, IEquatable<F>, INullary<F>
        where T : struct
        where F : struct, ISpan<F,T>
    {

    }

}