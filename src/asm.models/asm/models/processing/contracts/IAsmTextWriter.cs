//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public delegate IAsmTextWriter AsmTextWriterFactory(FilePath dst, IAsmFormatter formatter);

    public interface IAsmTextWriter : IFileStreamWriter
    {
        void WriteAsm(params AsmRoutine[] src);
    }
}