//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOp128 : IRegOp<W128,Fixed128>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.XMM;
    }
}