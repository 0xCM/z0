//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using Z0.Asm;

    [Free]
    public interface IImmOp : IAsmOp, ITextual
    {
        AsmOpClass Class => AsmOpClass.Imm;
    }

    [Free]
    public interface IImmOp<T> : IImmOp, IContented<T>
        where T : unmanaged
    {
        BitWidth ISized.Width
            => core.size<T>();
    }

    public interface IImm : IImmOp
    {

    }

    public interface IImm<T> : IImm, IImmOp<T>, IDataType<T>
        where T : unmanaged
    {
        //T Content {get;}
    }

    public interface IImm<F,T> : IImm<T>
        where F : unmanaged, IImm<F,T>
        where T : unmanaged
    {

    }
}