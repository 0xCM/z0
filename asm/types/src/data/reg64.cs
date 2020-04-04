//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{

    public interface reg64 : reg<W64>
    {

    }

    public interface reg64<F> : reg64
        where F : struct, reg64<F>
    {

    }

    public readonly struct rax : reg64<rax>
    {

    }

    public readonly struct rcx : reg64<rcx>
    {

    }    

    public readonly struct rdx : reg64<rdx>
    {

    }    

    public readonly struct rbx : reg64<rbx>
    {

    }    

    public readonly struct rsi : reg64<rsi>
    {


    }    

    public readonly struct rdi : reg64<rdi>
    {


    }        

    public readonly struct rsp : reg64<rsp>
    {


    }            

    public readonly struct rbp : reg64<rbp>
    {


    }                

    public readonly struct r8 : reg64<r8>
    {


    }                    

    public readonly struct r9 : reg64<r9>
    {


    }                        

    public readonly struct r10 : reg64<r10>
    {


    }                        

    public readonly struct r11 : reg64<r11>
    {


    }                        

    public readonly struct r12 : reg64<r12>
    {


    }                    

    public readonly struct r13 : reg64<r13>
    {


    }                        

    public readonly struct r14 : reg64<r14>
    {


    }                        

    public readonly struct r15 : reg64<r15>
    {


    }                        
}