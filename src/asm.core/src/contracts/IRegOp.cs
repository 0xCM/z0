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

    /// <summary>
    /// Characterizes an operand representation of an 8-bit register
    /// </summary>
    [Free]
    public interface IRegOp8 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W8;
    }

    [Free]
    public interface IRegOp8<T> : IRegOp8, IRegOp<T>
        where T : unmanaged, IRegOp8<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.GP;
    }

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

    [Free]
    public interface IRegOp64 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W64;
    }

    [Free]
    public interface IRegOp64<T> : IRegOp64, IRegOp<T>
        where T : unmanaged, IRegOp64<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.GP;
    }

    /// <summary>
    /// Characterizes an operand representation of a 128-bit register
    /// </summary>
    [Free]
    public interface IRegOp128 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W128;
    }

    [Free]
    public interface IRegOp128<T> : IRegOp128, IRegOp<T>
        where T : unmanaged, IRegOp128<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.XMM;
    }

    [Free]
    public interface IRegOp256 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W256;
    }

    [Free]
    public interface IRegOp256<T> : IRegOp256, IRegOp<T>
        where T : unmanaged, IRegOp256<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.YMM;
    }

    /// <summary>
    /// Characterizes an operand representation of a 512-bit register
    /// </summary>
    [Free]
    public interface IRegOp512 : IRegOp
    {
        AsmWidthCode IRegOp.WidthCode
            => AsmWidthCode.W512;
    }

    [Free]
    public interface IRegOp512<T> : IRegOp512, IRegOp<T>
        where T : unmanaged, IRegOp512<T>
    {
        RegClassCode IRegOp.RegClassCode
            => RegClassCode.ZMM;
    }
}