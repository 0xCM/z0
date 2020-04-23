//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IImmResover : ISFunc
    {
        NumericKind ImmKind => NumericKind.None;

        ArityValue ResolvedArity => ArityValue.Nullary;

        TypeWidth OperandWidth => TypeWidth.None;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImmResolver<T> : IImmResover
        where T : unmanaged
    {
        NumericKind IImmResover.ImmKind => NumericKinds.kind<T>();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8Resolver<V> : IImmResolver<byte>
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8UnaryResolver<W,V> : IImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeWidth
    {
        DynamicDelegate<UnaryOp<V>>  @delegate(byte imm8);  

        TypeWidth IImmResover.OperandWidth => Widths.type<W>();

        ArityValue IImmResover.ResolvedArity => ArityValue.Unary;           
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8BinaryResolver<W,V> : IImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeWidth
    {
        DynamicDelegate<BinaryOp<V>> @delegate(byte imm8);  

        TypeWidth IImmResover.OperandWidth => Widths.type<W>();

        ArityValue IImmResover.ResolvedArity => ArityValue.Binary;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8UnaryResolver128<T> : IImm8UnaryResolver<W128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8UnaryResolver256<T> : IImm8UnaryResolver<W256,Vector256<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8BinaryResolver128<T> : IImm8BinaryResolver<W128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8BinaryResolver256<T>  : IImm8BinaryResolver<W256,Vector256<T>>
        where T : unmanaged
    {
        
    }
}