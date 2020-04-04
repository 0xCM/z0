//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    public interface imm : data
    {

    }

    public interface imm<W> : imm, data<W>
        where W : unmanaged, IDataWidth
    {

    }

    public interface imm<F,W> : imm<W>
        where F : struct, imm<F,W>
        where W : unmanaged, IDataWidth
    {

    }

    public readonly struct imm8 : imm<imm8,W8>
    {

    }

    public readonly struct imm16 : imm<imm16,W16>
    {
        
    }    

    public readonly struct imm32 : imm<imm32,W32>
    {
        
    }        

    public readonly struct imm64 : imm<imm64,W64>
    {
        
    }            
}