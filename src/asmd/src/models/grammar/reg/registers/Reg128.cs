//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public readonly struct Reg128 : IXmmRegOp<Fixed128>
    {
        public const uint Width = IXmmRegOp.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }
}