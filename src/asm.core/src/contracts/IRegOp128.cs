//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operand representation of a 128-bit register
    /// </summary>
    [Free]
    public interface IRegOp128 : IRegOp
    {
        RegWidthCode IRegOp.WidthCode
            => RegWidthCode.W128;
    }

    [Free]
    public interface IRegOp128<T> : IRegOp128, IRegOp<T>
        where T : unmanaged, IRegOp128<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.XMM;
    }
}