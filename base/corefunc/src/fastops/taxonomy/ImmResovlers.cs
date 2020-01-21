//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public interface ImmResolver : IFunc
    {
        PrimalKind ImmKind => PrimalKind.None;

        OpArityKind ResolvedArity => OpArityKind.Nullary;

        FixedWidth OperandWidth => FixedWidth.None;

        SegmentationKind Segmentation => SegmentationKind.None;
    }

    public interface ImmResolver<T> : ImmResolver
        where T : unmanaged
    {
        PrimalKind ImmResolver.ImmKind => PrimalType.kind<T>();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface Imm8Resolver : ImmResolver<byte>
    {
            
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryImm8Resolver<T> : Imm8Resolver
        where T :struct
    {
        DynamicDelegate<UnaryOp<T>>  @delegate(byte imm8);  

        OpArityKind ImmResolver.ResolvedArity => OpArityKind.Unary;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryImm8Resolver<T> : Imm8Resolver
        where T :struct
    {
        DynamicDelegate<BinaryOp<T>>  @delegate(byte imm8);  

        OpArityKind ImmResolver.ResolvedArity => OpArityKind.Binary;        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVImm8Resolver<V> : Imm8Resolver
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver<W,V> : IVImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeNat
    {
        DynamicDelegate<UnaryOp<V>>  @delegate(byte imm8);  

        SegmentationKind ImmResolver.Segmentation => SegmentationKind.Vectorized;

        FixedWidth ImmResolver.OperandWidth => (FixedWidth)nateval<W>();

        OpArityKind ImmResolver.ResolvedArity => OpArityKind.Unary;           
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver<W,V> : IVImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeNat
    {
        DynamicDelegate<BinaryOp<V>>  @delegate(byte imm8);  

        SegmentationKind ImmResolver.Segmentation => SegmentationKind.Vectorized;

        FixedWidth ImmResolver.OperandWidth => (FixedWidth)nateval<W>();

        OpArityKind ImmResolver.ResolvedArity => OpArityKind.Binary;           

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver128<T> : IVUnaryImm8Resolver<N128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver256<T> : IVUnaryImm8Resolver<N256,Vector256<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver128<T> : IVBinaryImm8Resolver<N128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver256<T>  : IVBinaryImm8Resolver<N256,Vector256<T>>
        where T : unmanaged
    {
        
    }
}