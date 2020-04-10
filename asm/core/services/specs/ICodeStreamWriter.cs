//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface ICodeStreamWriter : IAsmStreamWriter
    {
        void WriteHexLine(in CapturedOp src, int? idpad = null);

        void WriteCode(in AsmCode src, int? idpad = null);

        void Write(AsmCode[] src);

        void WriteDiagnostic(in CapturedOp src);        
    }
}