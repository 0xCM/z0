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

    }

    /// <summary>
    /// Characterizes a register operand reprentation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Free]
    public interface IRegOp16<T> : IRegOp16, IRegOp<T>
        where T : unmanaged
    {
    }

}