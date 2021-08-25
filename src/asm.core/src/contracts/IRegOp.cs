//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Root;
    using static core;

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
        RegClassCode RegClassCode {get;}

        /// <summary>
        /// The width of the represented register operand
        /// </summary>
        AsmWidthCode WidthCode {get;}


        ushort Bitfield {get;}

        BitWidth ISized.Width
            => (uint)WidthCode;

        ByteSize ISized.Size
            => ((uint)WidthCode)/8;

        RegWidth RegWidth
            => WidthCode;

        RegClass RegClass
            => RegClassCode;

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
        ushort IRegOp.Bitfield
            => u16(this);
        AsmOpClass IAsmOp.OpClass
            => AsmOpClass.R | (AsmOpClass)width<T>(w16);

        BitWidth ISized.Width
            => width<T>();

        ByteSize ISized.Size
            => size<T>();
    }
}