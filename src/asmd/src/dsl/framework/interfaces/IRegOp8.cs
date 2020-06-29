//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOp8 : IRegOp<W8,byte>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }
}