//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;

    using static SFx;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {


    }

    [Free, SFx]
    public interface IImmResover : IFunc
    {
        NumericKind ImmKind
            => NumericKind.None;

        ArityValue ResolvedArity
            => ArityValue.Nullary;

        TypeWidth OperandWidth
            => TypeWidth.None;
    }

    [Free, SFx]
    public interface IImmResolver<T> : IImmResover
        where T : unmanaged
    {
        NumericKind IImmResover.ImmKind
            => NumericKinds.kind<T>();
    }

    [Free, SFx]
    public interface IImm8Resolver<V> : IImmResolver<byte>
        where V : struct
    {

    }

    [Free, SFx]
    public interface IImm8UnaryResolver<W,V> : IImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeWidth
    {
        DynamicDelegate<UnaryOp<V>>  @delegate(byte imm8);

        TypeWidth IImmResover.OperandWidth
            => Widths.type<W>();

        ArityValue IImmResover.ResolvedArity
            => ArityValue.Unary;
    }

    [Free, SFx]
    public interface IImm8BinaryResolver<W,V> : IImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeWidth
    {
        DynamicDelegate<BinaryOp<V>> @delegate(byte imm8);

        TypeWidth IImmResover.OperandWidth
            => Widths.type<W>();

        ArityValue IImmResover.ResolvedArity
            => ArityValue.Binary;
    }

    [Free, SFx]
    public interface IImm8UnaryResolver128<T> : IImm8UnaryResolver<W128,Vector128<T>>
        where T : unmanaged
    {

    }

    [Free, SFx]
    public interface IImm8UnaryResolver256<T> : IImm8UnaryResolver<W256,Vector256<T>>
        where T : unmanaged
    {

    }

    [Free, SFx]
    public interface IImm8BinaryResolver128<T> : IImm8BinaryResolver<W128,Vector128<T>>
        where T : unmanaged
    {

    }

    [Free, SFx]
    public interface IImm8BinaryResolver256<T>  : IImm8BinaryResolver<W256,Vector256<T>>
        where T : unmanaged
    {

    }
}