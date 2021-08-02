//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Root;
    using static core;
    using static AsmCodes;

    /// <summary>
    /// Characterizes a register operand representation
    /// </summary>
    [Free]
    public interface IRegOp : IAsmOp, ITextual
    {
        /// <summary>
        /// The register index code
        /// </summary>
        RegIndexCode Index {get;}

        /// <summary>
        /// The register classifier
        /// </summary>
        RegClassCode RegClass {get;}

        BitWidth ISized.Width
            => (uint)Width;

        ByteSize ISized.Size
            => ((uint)Width)/8;

        /// <summary>
        /// The width of the represented register operand
        /// </summary>
        new RegWidthCode Width {get;}

        string ITextual.Format()
            => GetType().Name;
    }

    /// <summary>
    /// Characterizes a parametric register operand representation
    /// </summary>
    /// <typeparam name="T">The represented storage type</typeparam>
    [Free]
    public interface IRegOp<T> : IRegOp, ISized<T>
        where T : unmanaged
    {
        AsmOpClass IAsmOp.OpClass
            => AsmOpClass.R | (AsmOpClass)width<T>(w16);

        BitWidth ISized.Width
            => width<T>();

        ByteSize ISized.Size
            => size<T>();
    }
}