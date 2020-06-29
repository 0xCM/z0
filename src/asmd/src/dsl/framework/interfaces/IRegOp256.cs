//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOp256 : IRegOp<W256,Fixed256>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.YMM;
    }
}