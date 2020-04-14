//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBitFieldOps<T> : IService
        where T : unmanaged
    {
        T Read(in FieldSegment segment, T src);

        ref T Write(in FieldSegment segment, in T src, ref T dst);  

        T Read(in FieldSegment segment, T src, bool offset);

        void Read(in BitFieldSpec spec, T src, Span<T> dst);

        void Read<E,W>(in BitFieldSpec<E,W> spec, T src, Span<T> dst)
            where E : unmanaged, Enum
            where W : unmanaged, Enum;        

        ref T Write(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst);
    }

    public interface IBitFieldOps<S,T> : IService
        where S : IScalarField<T>
        where T : unmanaged    
    {
        T Read(in FieldSegment segment, in S src);

        T Read(in FieldSegment segment, in S src, bool offset);                    

        void Read(in BitFieldSpec spec, in S src, Span<T> dst);
        
        ref T Write(in FieldSegment segment, in S src, ref T dst);

        ref S Write(in FieldSegment segment, in S src, ref S dst);

        ref T Write(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T data);
    }
}