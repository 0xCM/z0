//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a register representation
    /// </summary>
    public interface IReg
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegKind RegKind {get;}

        RegIndex Index
            => (RegIndex)((byte)RegKind);
    }

    public interface IReg<T> : IReg, IContented<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IReg<W,T> : IReg<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IReg8<T> : IReg<W8,T>
        where T : unmanaged
    {

    }

    public interface IReg16<T> : IReg<W16,T>
        where T : unmanaged
    {

    }

    public interface IReg32<T> : IReg<W32,T>
        where T : unmanaged
    {

    }

    public interface IReg64<T> : IReg<W64,T>
        where T : unmanaged
    {

    }

    public interface IReg128<T> : IReg<W128,T>
        where T : unmanaged
    {

    }

    public interface IReg256<T> : IReg<W256,T>
        where T : unmanaged
    {

    }

    public interface IReg512<T> : IReg<W512,T>
        where T : unmanaged
    {

    }

    public interface IReg8<H,T> : IReg8<T>
        where H : struct, IReg8<H,T>
        where T : unmanaged
    {

    }

    public interface IReg16<H,T> : IReg16<T>
        where H : struct, IReg16<H,T>
        where T : unmanaged
    {

    }

    public interface IReg32<H,T> : IReg32<T>
        where H : struct, IReg32<H,T>
        where T : unmanaged
    {

    }

    public interface IReg64<H,T> : IReg64<T>
        where H : struct, IReg64<H,T>
        where T : unmanaged
    {

    }

    public interface IReg128<H,T> : IReg128<T>
        where H : struct, IReg128<H,T>
        where T : unmanaged
    {

    }

    public interface IReg256<H,T> : IReg256<T>
        where H : struct, IReg256<H,T>
        where T : unmanaged
    {

    }

    public interface IReg512<H,T> : IReg512<T>
        where H : struct, IReg512<H,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IReg<F,W,T> : IReg<W,T>
        where F : struct, IReg<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IReg<F,W,T,N> : IReg<F,W,T>
        where F : struct, IReg<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        RegIndex IReg.Index
            => (RegIndex)TypeNats.nat8u<N>();
    }
}