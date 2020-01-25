//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    using Iced = Iced.Intel;

    using Z0.AsmSpecs;

    public interface IAsmWriter : IDisposable
    {

        void WriteFunction(AsmFunction src, AsmFormatConfig fmt);

        void WriteFunction(MemberCapture src, AsmFormatConfig fmt);

        byte[] TakeBuffer();   

    }


    interface IIcedAsmFormatter
    {
        ReadOnlySpan<string> CaptureBaseFormat(Iced.InstructionList src, ulong baseaddress);
    }

}