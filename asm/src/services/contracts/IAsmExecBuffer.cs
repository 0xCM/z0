
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IAsmExecBuffer : IAsmService, IDisposable
    {
        IntPtr Load(in AsmCode src);
        
        FixedFunc<X0,R> F<X0,R>(in AsmCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed ;            

        FixedFunc<X0,X1,R> F<X0,X1,R>(in AsmCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed;         

        FixedFunc<T,T> UnaryOp<T>(in AsmCode src)
            where T : unmanaged, IFixed;
        
        FixedFunc<T,T,T> BinaryOp<T>(in AsmCode src)
            where T : unmanaged, IFixed
                => F<T,T,T>(src);
     }
}