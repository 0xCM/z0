//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public delegate IAsmRoutineWriter AsmWriterFactory(FilePath dst, IAsmFormatter formatter);

    public interface IAsmRoutineWriter : IFileStreamWriter
    {
        void WriteAsm(params AsmRoutine[] src);
    }
}