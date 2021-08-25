//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operand representation of a 32-bit register
    /// </summary>
    [Free]
    public interface IRegOp32 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W32;
    }

    [Free]
    public interface IRegOp32<T> : IRegOp32, IRegOp<T>
        where T : unmanaged, IRegOp32<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.GP;
    }
}