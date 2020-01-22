//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    public interface IAsmWriter : IDisposable
    {
        byte[] TakeBuffer();   

        void WriteHeader(AsmFormatConfig fmt);

        void WriteSeparator(AsmFormatConfig fmt);        

        void WriteFunction(AsmFunction src, AsmFormatConfig fmt);

        void WriteFunction(NativeMemberCapture src, AsmFormatConfig fmt);
    }

}