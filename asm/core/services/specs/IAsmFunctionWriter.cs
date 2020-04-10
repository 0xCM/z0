//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public delegate IAsmFunctionWriter AsmWriterFactory(FilePath dst, IAsmFormatter formatter);

    public interface IAsmFunctionWriter : IAsmStreamWriter
    {
        void Write(params AsmFunction[] src);
    }
}