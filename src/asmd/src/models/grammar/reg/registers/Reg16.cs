//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using Z0.Asm.Data;

    public readonly struct Reg16 : IRegOp16<Fixed16>
    {    
        public const uint Width = IRegOp16.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }

}