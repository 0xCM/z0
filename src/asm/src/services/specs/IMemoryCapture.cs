//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IMemoryCapture : IService
    {
        Option<LocatedCode> Extract(MemoryAddress src);        

        Option<ApiMemoryCapture> Capture(MemoryAddress src);        

        Option<LocatedCode> Parse(LocatedCode src);

        Option<AsmInstructionList> Decode(LocatedCode src);                    
    }
}