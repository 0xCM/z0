//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operand representation of a 512-bit register
    /// </summary>
    [Free]
    public interface IRegOp512 : IRegOp
    {
        RegWidthCode IRegOp.Width
            => RegWidthCode.W512;
    }

    [Free]
    public interface IRegOp512<T> : IRegOp512, IRegOp<T>
        where T : unmanaged, IRegOp512<T>
    {
        RegClassCode IRegOp.RegClass
            => RegClassCode.ZMM;
    }
}