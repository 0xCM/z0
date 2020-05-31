//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    public readonly struct Reg256 : IYmmRegOp<Fixed256>
    {
        public const uint Width = IYmmRegOp.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }
}