//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public readonly struct Reg8 : IRegOp8<Fixed8>
    {    
        public const uint Width = IRegOp8.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }
}