//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IMemoryCapture : IService
    {
        Option<Addressable> Extract(MemoryAddress src);        

        Option<ApiMemoryCapture> Capture(MemoryAddress src);        

        Option<Addressable> Parse(Addressable src);

        Option<AsmInstructionList> Decode(Addressable src);                    
    }
}