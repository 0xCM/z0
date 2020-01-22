
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface INativeExecBuffer : IDisposable
    {
        int BufferSize {get;}

        UnaryOp8 UnaryOp(N8 w, in AsmCode code);        

        UnaryOp16 UnaryOp(N16 w, in AsmCode code);                

        UnaryOp32 UnaryOp(N32 w, in AsmCode code);

        UnaryOp64 UnaryOp(N64 w, in AsmCode code);

        UnaryOp128 UnaryOp(N128 w, in AsmCode code);

        UnaryOp256 UnaryOp(N256 w, in AsmCode code);

        UnaryOp<T> UnaryOp<T>(in AsmCode<T> code)
            where T : unmanaged;

        BinaryOp8 BinaryOp(N8 w, in AsmCode code);        

        BinaryOp16 BinaryOp(N16 w, in AsmCode code);                

        BinaryOp32 BinaryOp(N32 w, in AsmCode code);

        BinaryOp64 BinaryOp(N64 w, in AsmCode code);

        BinaryOp128 BinaryOp(N128 w, in AsmCode code);

        BinaryOp256 BinaryOp(N256 w, in AsmCode code);

        BinaryOp<T> BinaryOp<T>(in AsmCode<T> code)
            where T : unmanaged;
    }
}