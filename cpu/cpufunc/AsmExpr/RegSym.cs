//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public interface IRegSym<T> : IRegExpr<T>
        where T : unmanaged, Enum
    {

    }

    /// <summary>
    /// Each subtype defines symbol that uniquely identifies a register
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RegSym<T> : RegExpr<T>, IRegSym<T>
        where T: unmanaged,  Enum
    {

        protected RegSym(T Kind)
            : base(Kind)
        {

        }
    }

    public interface IReg8 : IRegSym<GpRegId8>
    {
        
    }

    /// <summary>
    /// Defines base type for symbols that represent 8-bit registers
    /// </summary>
    public abstract class Reg8 : RegSym<GpRegId8>, IReg8
    {
        protected Reg8(GpRegId8 kind)
            : base(kind)
        {

        }

    }

    public interface IReg16 : IRegSym<GpRegId16>
    {
        
    }

    /// <summary>
    /// Defines base type for symbols that represent 16-bit registers
    /// </summary>
    public abstract class Reg16 : RegSym<GpRegId16>, IReg16
    {
        protected Reg16(GpRegId16 kind)
            : base(kind)
        {

        }

    }

    public interface IReg32 : IRegSym<GpRegId32>
    {
        
    }

    /// <summary>
    /// Defines base type for symbols that represent 32-bit registers
    /// </summary>
    public abstract class Reg32 : RegSym<GpRegId32>, IReg32
    {
        protected Reg32(GpRegId32 kind)
            : base(kind)
        {

        }

    }

    public interface IReg64 : IRegSym<GpRegId64>
    {
        
    }

    /// <summary>
    /// Defines base type for symbols that represent 64-bit registers
    /// </summary>
    public abstract class Reg64: RegSym<GpRegId64>, IReg64
    {
        protected Reg64(GpRegId64 kind)
            : base(kind)
        {

        }

    }


    public interface IReg128 : IRegSym<XmmRegId>
    {
        
    }

    /// <summary>
    /// Defines base type for symbols that represent 128-bit XMM registers
    /// </summary>
    public abstract class Reg128: RegSym<XmmRegId>, IReg128
    {
        protected Reg128(XmmRegId kind)
            : base(kind)
        {

        }

    }

    public interface IReg256 : IRegSym<YmmRegId>
    {
        
    }

    /// <summary>
    /// Defines base type for symbols that represent 256-bit YMM registers
    /// </summary>
    public abstract class Reg256: RegSym<YmmRegId>, IReg256
    {
        protected Reg256(YmmRegId kind)
            : base(kind)
        {

        }

    }


}