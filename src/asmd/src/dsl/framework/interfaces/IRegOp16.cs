//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOp16 : IRegOp<W16,ushort>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }
}