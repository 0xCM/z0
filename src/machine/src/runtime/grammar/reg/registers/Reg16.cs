//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using Z0.Asm.Data;

    public readonly struct Reg16 : IReg16<Fixed16>
    {    
        public const uint Width = IReg16.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }

}