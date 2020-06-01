//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFieldOps<S,T> : IService
        where S : IScalarField<T>
        where T : unmanaged    
    {
        T Extract(in FieldSegment seg, in S src);

        T Extract(in FieldSegment seg, in S src, bool offset);                    

        void Deposit(in BitFieldSpec spec, in S src, Span<T> dst);
        
        ref T Deposit(in FieldSegment seg, in S src, ref T dst);

        ref S Deposit(in FieldSegment seg, in S src, ref S dst);

        ref T Deposit(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst);
    }
}