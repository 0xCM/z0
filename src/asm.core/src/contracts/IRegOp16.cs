//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a register operand reprentation
    /// </summary>
    [Free]
    public interface IRegOp16 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W16;
    }

    [Free]
    public interface IRegOp16<T> : IRegOp16, IRegOp<T>
        where T : unmanaged, IRegOp16<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.GP;
    }
}