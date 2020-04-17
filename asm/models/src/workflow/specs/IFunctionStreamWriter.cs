//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public delegate IFunctionStreamWriter AsmWriterFactory(FilePath dst, IAsmFormatter formatter);

    public interface IFunctionStreamWriter : IFileStreamWriter
    {
        void Write(params AsmFunction[] src);
    }
}