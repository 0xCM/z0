//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRegOp256 : IRegOp
    {
        RegWidthCode IRegOp.Width
            => RegWidthCode.W256;

    }

    [Free]
    public interface IRegOp256<T> : IRegOp256, IRegOp<T>
        where T : unmanaged, IRegOp256<T>
    {
        RegClassCode IRegOp.RegClass
            => RegClassCode.YMM;
    }
}