//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    /// <summary>
    /// Each subtype defines symbol that uniquely identifies a register
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RegSym<T> : RegExpr<T>
        where T : Enum
    {

        protected RegSym(T Kind)
            : base(Kind)
        {

        }
    }

    /// <summary>
    /// Defines base type for symbols that represent 8-bit registers
    /// </summary>
    public abstract class Reg8 : RegSym<GpRegId8>
    {
        protected Reg8(GpRegId8 kind)
            : base(kind)
        {

        }

    }

    /// <summary>
    /// Defines base type for symbols that represent 16-bit registers
    /// </summary>
    public abstract class Reg16 : RegSym<GpRegId16>
    {
        protected Reg16(GpRegId16 kind)
            : base(kind)
        {

        }

    }

    /// <summary>
    /// Defines base type for symbols that represent 32-bit registers
    /// </summary>
    public abstract class Reg32 : RegSym<GpRegId32>
    {
        protected Reg32(GpRegId32 kind)
            : base(kind)
        {

        }

    }

    /// <summary>
    /// Defines base type for symbols that represent 64-bit registers
    /// </summary>
    public abstract class Reg64: RegSym<GpRegId64>
    {
        protected Reg64(GpRegId64 kind)
            : base(kind)
        {

        }

    }

    /// <summary>
    /// Defines base type for symbols that represent 128-bit XMM registers
    /// </summary>
    public abstract class Reg128: RegSym<XmmRegId>
    {
        protected Reg128(XmmRegId kind)
            : base(kind)
        {

        }

    }

    /// <summary>
    /// Defines base type for symbols that represent 256-bit YMM registers
    /// </summary>
    public abstract class Reg256: RegSym<YmmRegId>
    {
        protected Reg256(YmmRegId kind)
            : base(kind)
        {

        }

    }


}