//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using Z0.Asm.Data;

    public readonly struct Reg8 : IReg8<Fixed8>
    {    
        public const uint Width = IReg8.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }
}