//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDataResolver
    {
        TypeWidth TargetWidth {get;}

        DataWidth CellWidth
            => (DataWidth)TargetWidth;

        Type RefiningType
            => typeof(void);

        bool Refined
            => RefiningType == typeof(void);
    }

    public interface IDataResolver<D> : IDataResolver
        where D : struct
    {
        void Resolve(ref D dst);

        void Resolve(uint count, Span<D> dst);
    }

    /// <summary>
    /// Characterizes a resolver that produces <typeparamref name='T'/> and <typeparamref name='C'/>-stratified
    /// <typeparamref name='D'/>-values of width <typeparamref name='W'/>
    /// </summary>
    /// <typeparam name="W">The resolution width</typeparam>
    /// <typeparam name="D">The resolution type</typeparam>
    /// <typeparam name="C">The cell type, bitwise equivalent to the primitive resolution type</typeparam>
    /// <typeparam name="T">The primitive resolution type, bitwise equivalent to the cellular type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IDataResolver<W,D,C,T> : ICellResolver<W,C,T>
        where W : unmanaged, ITypeWidth
        where D : unmanaged
        where C : unmanaged, ICellHost<C,W,T>
        where T : unmanaged
    {
        TypeWidth IDataResolver.TargetWidth
            => Widths.type<W>();

        DataWidth IDataResolver.CellWidth
            => Widths.data<W>();


        void Resolve(ref D dst);

    }

    /// <summary>
    /// Characterizes a resolver that produces <typeparamref name='E'/>-refined  <typeparamref name='T'/> and
    /// <typeparamref name='C'/>-stratified <typeparamref name='D'/>-values of width <typeparamref name='W'/>
    /// </summary>
    /// <typeparam name="W">The resolution width</typeparam>
    /// <typeparam name="D">The resolution type</typeparam>
    /// <typeparam name="C">The cell type, bitwise equivalent to the primitive resolution type</typeparam>
    /// <typeparam name="E">The refining type</typeparam>
    /// <typeparam name="T">The primitive resolution type, bitwise equivalent to the cellular type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IDataResolver<W,D,C,E,T> : IDataResolver<W,D,C,T>, IRefiningResolver<W,E,T>
        where W : unmanaged, ITypeWidth
        where D : unmanaged
        where C : unmanaged, ICellHost<C,W,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {

    }
}