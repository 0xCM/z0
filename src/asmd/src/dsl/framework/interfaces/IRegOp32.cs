//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    public interface IRegOp32 : IRegOp<W32,uint>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }


}