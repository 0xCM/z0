//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Control;

    /// <summary>
    /// Characterizes a register
    /// </summary>
    public interface IRegOp : IOperand
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Kind {get;}

        RegisterCode Code 
            => (RegisterCode)((byte)Kind);

        RegisterClass Class
            => default;

        OperandKind IOperand.OpKind 
            => OperandKind.R;
    }

    /// <summary>
    /// Characterizes a width-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<W,T> : IRegOp, IOperand<W,T>
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        
    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<F,W,T> : IRegOp<W,T>
        where T : unmanaged
        where F : struct, IRegOp<F,W,T>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface IRegOp8 : IRegOp<W8,byte>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }
    
    public interface IRegOp8<F,N> : IRegOp8
        where F : unmanaged, IRegOp8<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)Control.value<N>();
    }    

    public interface IRegOp16 : IRegOp<W16,ushort>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }

    public interface IRegOp16<F,N> : IRegOp16
        where F : unmanaged, IRegOp16<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    

    public interface IRegOp32 : IRegOp<W32,Fixed32>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }

    public interface IRegOp32<F,N> : IRegOp32
        where F : unmanaged, IRegOp32<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    

    public interface IRegOp64 : IRegOp<W64,Fixed64>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.GP;
    }

    public interface IRegOp64<F,N> : IRegOp64
        where F : unmanaged, IRegOp64<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    

    public interface IXmmRegOp : IRegOp<W128, Fixed128>    
    {        
        RegisterClass IRegOp.Class 
            => RegisterClass.XMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmRegOp<F,N> : IXmmRegOp
        where F : struct, IXmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    

    public interface IYmmRegOp : IRegOp<W256,Fixed256>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.YMM;
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmRegOp<F,N> : IYmmRegOp
        where F : struct, IYmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    

    public interface IZmmRegOp : IRegOp<W512,Fixed512>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.ZMM;        
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IZmmRegOp<F,N> : IZmmRegOp
        where F : struct, IZmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    
}