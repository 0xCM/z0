//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
 
 
    using static AsmSpecs;

    partial class AsmTypes
    {

        public readonly struct mem8 : mem<mem8,W8,Fixed8,address8>
        {
            public Fixed8 Content {get;}

            public address8 Location {get;}
        }

        public readonly struct mem16 : mem<mem16,W16,Fixed16,address16>
        {
            public Fixed16 Content {get;}

            public address16 Location {get;}
        }


        public readonly struct mem32 : mem<mem32,W32,Fixed32,address32>
        {
            public Fixed32 Content {get;}

            public address32 Location {get;}
        }

        public readonly struct mem64 : mem<mem64,W64,Fixed64,address64>
        {
            public Fixed64 Content {get;}

            public address64 Location {get;}
        }

    }
}