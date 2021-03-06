//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operand representation of an 8-bit register
    /// </summary>
    [Free]
    public interface IRegOp8 : IRegOp
    {
        RegWidthCode IRegOp.Width
            => RegWidthCode.W8;
    }

    [Free]
    public interface IRegOp8<T> : IRegOp8, IRegOp<T>
        where T : unmanaged, IRegOp8<T>
    {
        RegClassCode IRegOp.RegClass
            => RegClassCode.GP;
    }
}