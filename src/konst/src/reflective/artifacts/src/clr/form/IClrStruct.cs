//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.ClrData;

    /// <summary>
    /// Characterizes a model of an unmanaged type
    /// </summary>
    public interface IClrStruct : IClrType
    {
        ClrTypeKind IClrType.Kind 
            => ClrTypeKind.Struct;        
    }

    /// <summary>
    /// Characterizes an F-bound polyorphic unmanaged type model reification
    /// </summary>
    /// <typeparam name="M">The reifying type</typeparam>
    public interface IClrStruct<M> : IClrStruct, IClrType<M>
        where M : struct, IClrStruct<M>
    {

    }

    /// <summary>
    /// Characterizes a subject-parametric model of an unmanaged type
    /// </summary>
    /// <typeparam name="M">The reified model type</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrStruct<M,T> : IClrStruct<M>, IClrType<M,T>
        where M : struct, IClrStruct<M>
        where T : unmanaged
    {
        ClrType IClrType<M>.Generalized 
            => Untyped.Generalized;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and subject-parametric model of an unmanaged type
    /// </summary>
    /// <typeparam name="X">The reifying type</typeparam>
    /// <typeparam name="M">The reifying type of the equivalent non-parametric model</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrStruct<X,M,T> : IClrStruct<M,T>
        where M : struct, IClrStruct<M>
        where X : struct, IClrStruct<X,M,T>
        where T : unmanaged
    {

    }
}