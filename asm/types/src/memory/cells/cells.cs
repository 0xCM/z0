//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
 
    using static AsmSpecs;

    partial class AsmTypes
    {
        public readonly struct cell8 : mem<cell8,W8,Fixed8>
        {
            public Fixed8 Content {get;}                        
        }

        public readonly struct cell16 : mem<cell16,W16,Fixed16>
        {
            public Fixed16 Content {get;}
        }    

        public readonly struct cell32 : mem<cell32,W32,Fixed32>
        {
            public Fixed32 Content {get;}
        }        

        public readonly struct cell64 : mem<cell64,W64,Fixed64>
        {
            public Fixed64 Content {get;}
        }            
    }
}