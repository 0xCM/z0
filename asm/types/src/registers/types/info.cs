//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;

    using K = RegisterKind;

    public readonly struct R8 : reg8<Fixed8>
    {    
        public const uint Width = reg8.Width;

        public Fixed8 State {get;}

        public string Name {get;}

        public K Kind {get;}

        public int Position {get;}
    }

    public readonly struct R16 : reg16<Fixed16>
    {    
        public const uint Width = reg16.Width;

        public Fixed16 State {get;}

        public string Name {get;}

        public K Kind {get;}

        public int Position {get;}
    }

    public readonly struct R32 : reg32<Fixed32>
    {    
        public const uint Width = reg32.Width;

        public Fixed32 State {get;}

        public string Name {get;}

        public K Kind {get;}

        public int Position {get;}
    }

    public readonly struct R64 : reg64<Fixed64>
    {    
        public const uint Width = reg64.Width;

        public Fixed64 State {get;}

        public string Name {get;}

        public K Kind {get;}

        public int Position {get;}
    }   

    public readonly struct Reg128 : xmm<Fixed128V>
    {
        public const uint Width = xmm.Width;

        public Fixed128V State {get;}

        public string Name {get;}

        public int Position {get;}

    }

    public readonly struct Reg256 : ymm<Fixed256V>
    {
        public const uint Width = ymm.Width;

        public Fixed256V State {get;}

        public string Name {get;}

        public int Position {get;}
    }

    public readonly struct Reg512 : ymm<Fixed512V>
    {
        public const uint Width = zmm.Width;

        public Fixed512V State {get;}

        public string Name {get;}

        public int Position {get;}
    }

}