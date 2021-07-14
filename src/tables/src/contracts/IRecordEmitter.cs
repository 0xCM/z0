//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRecordEmitter : IDisposable
    {
        void EmitHeader();
    }

    public interface IRecordEmitter<T> : IRecordEmitter
        where T : struct
    {
        void Emit(in T src);

        void Emit(ReadOnlySpan<T> src);
    }
}