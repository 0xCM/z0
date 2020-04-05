//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
 
    using static AsmSpecs;
    using static AsmTypes;

    partial class AsmSpecs
    {
        public interface mem : data
        {

        }

        public interface mem<W> : mem
            where W : unmanaged, IDataWidth
        {
            address Address {get;}

            uint sized.Size => Widths.measure<W>(); 
        }

        public interface mem<F,A,W> : mem<W>
            where F : unmanaged, mem<F,A,W>
            where W : unmanaged, IDataWidth
            where A : address<W>
        {
            new A Address {get;}
                    
            address mem<W>.Address => new address(Address.Scalar);
        }
    }

    partial class AsmTypes
    {
        public readonly struct mem8 : mem<mem8,address8,W8>
        {
            public address8 Address {get;}        
        }

        public readonly struct mem16 : mem<mem16,address16,W16>
        {
            public address16 Address {get;}
            
        }    

        public readonly struct mem32 : mem<mem32,address32,W32>
        {
            public address32 Address {get;}        
        }        

        public readonly struct mem64 : mem<mem64,address64,W64>
        {
            public address64 Address {get;}        
        }            
    }
}