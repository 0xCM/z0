//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOp64 : IRegOp<W64,ulong>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }
}