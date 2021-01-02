//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public delegate IAsmWriter AsmTextWriterFactory(FilePath dst, IAsmFormatter formatter);

    public interface IAsmWriter : IDisposable
    {
        void WriteAsm(params AsmRoutine[] src);
    }
}