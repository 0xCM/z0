//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    using Z0.AsmSpecs;

    public interface IAsmFunctionWriter : IDisposable
    {

        void Write(AsmFunction src);

        void Write(AsmFunctionGroup src);
        
        byte[] TakeBuffer();   

    }
}