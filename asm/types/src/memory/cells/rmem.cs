//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0;
    using static AsmSpecs;
    using static AsmTypes;

    partial class Registers
    {
        public readonly struct rmem8 : rmem8<rmem8>
        {
            public Fixed8 State {get;}

            public address8 Address {get;}
        }

        public readonly struct rmem16 : rmem16<rmem16>
        {
            public Fixed16 State {get;}

            public address16 Address {get;}
            
        }    

        public readonly struct rmem32 : rmem32<rmem32>
        {
            public Fixed32 State {get;}

            public address32 Address {get;}            
        }        

        public readonly struct rmem64 : rmem64<rmem64>
        {
            public Fixed64 State {get;}

            public address64 Address {get;}
            
        }            
    }
}