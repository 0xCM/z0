//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{

    public interface reg8 : reg<W8>
    {

    }

    public interface reg8<F> : reg8
        where F : struct, reg8<F>
    {

    }

    public readonly struct al : reg8<al>
    {

    }

    public readonly struct ah : reg8<ah>
    {

    }

    public readonly struct cl : reg8<cl>
    {

    }    

    public readonly struct ch : reg8<bh>
    {

    }    

    public readonly struct dl : reg8<dl>
    {

    }    

    public readonly struct dh : reg8<dh>
    {

    }    

    public readonly struct bl : reg8<bl>
    {

    }    

    public readonly struct bh : reg8<bh>
    {

    }    

    public readonly struct sil : reg8<sil>
    {

    }    

    public readonly struct dil : reg8<dil>
    {

    }        

    public readonly struct spl : reg8<spl>
    {

    }            

    public readonly struct bpl : reg8<bpl>
    {


    }                

    public readonly struct r8b : reg8<r8b>
    {


    }                    

    public readonly struct r9b : reg8<r9b>
    {

    }                        

    public readonly struct r10b : reg8<r10b>
    {

    }                        

    public readonly struct r11b : reg8<r11b>
    {


    }                        

    public readonly struct r12b : reg8<r12b>
    {


    }                    

    public readonly struct r13b : reg8<r13b>
    {

    }                        

    public readonly struct r14b : reg8<r14b>
    {


    }                        

    public readonly struct r15b : reg8<r15b>
    {


    }
}