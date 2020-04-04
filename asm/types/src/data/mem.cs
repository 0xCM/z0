//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
 
    public interface mem : data
    {

    }

    public interface mem<W> : mem, data<W>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface mem<F,W> : mem<W>
        where F : struct, mem<F,W>
        where W : unmanaged, IDataWidth
    {
       
    }

    public readonly struct mem8 : mem<mem8,W8>
    {

    }

    public readonly struct mem16 : mem<mem16,W16>
    {
        
    }    

    public readonly struct mem32 : mem<mem32,W32>
    {
        
    }        

    public readonly struct mem64 : mem<mem64,W64>
    {
        
    }            
}