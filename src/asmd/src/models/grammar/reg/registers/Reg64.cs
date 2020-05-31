//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public readonly struct Reg64 : IRegOp64<Fixed64>
    {    
        public const uint Width = IRegOp64.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }   

}