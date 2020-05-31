//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    public readonly struct Reg512 : IYmmRegOp<Fixed512>
    {
        public const uint Width = IZmmRegOp.Width;

        public string Name {get;}

        public RegisterKind Kind {get;}

        public int Index {get;}
    }
}