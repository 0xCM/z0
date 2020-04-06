//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
 
    using static AsmSpecs;

    partial class AsmTypes
    {
        public readonly struct mem8 : mem<mem8,W8,address8>
        {
            public address8 Address {get;}        
        }

        public readonly struct mem16 : mem<mem16,W16,address16>
        {
            public address16 Address {get;}            
        }    

        public readonly struct mem32 : mem<mem32,W32,address32>
        {
            public address32 Address {get;}        
        }        

        public readonly struct mem64 : mem<mem64,W64,address64>
        {
            public address64 Address {get;}        
        }            
    }
}