//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace lang
{
    using Z0;

    using static Z0.core;

    public interface ILang
    {
        LangIdentifier Identifier {get;}
    }

    public interface ITypeDomain
    {
        LangIdentifier LangId {get;}
    }

    public interface ITypeDomain<T> : ITypeDomain
        where T : ILang, new()
    {
        T Lang {get;}

        LangIdentifier ITypeDomain.LangId
            => Lang.Identifier;
    }

    public interface ITypeDomain<K,T> : ITypeDomain<T>
        where K : unmanaged
        where T : ILang, new()
    {
        K Kind {get;}
    }

    public interface IType
    {
        string TypeName {get;}

        ByteSize StorageSize {get;}

        BitWidth DataWidth {get;}
    }

    public interface IType<S> : IType
        where S : unmanaged
    {
        ByteSize IType.StorageSize
            => size<S>();
    }

    public interface ICellular : IType
    {
        BitWidth CellWidth {get;}

        uint CellCount {get;}

        BitWidth IType.DataWidth
            => CellCount*CellWidth;
    }

    public interface IScalar : IType
    {
        uint N  {get;}

        BitWidth IType.DataWidth
            => N;
    }

    public interface IScalar<S> : IScalar, IType<S>
        where S : unmanaged
    {

    }

    public interface IIntegral : IScalar
    {

    }

    public interface IIntegral<S> : IIntegral, IScalar<S>
        where S : unmanaged
    {

    }

    public interface IFloat : IScalar
    {

    }

    public interface IFloat<S> : IFloat, IScalar<S>
        where S : unmanaged
    {

    }

    public interface IUnsigned : IIntegral
    {
    }

    public interface IUnsigned<S> : IUnsigned, IIntegral<S>
        where S : unmanaged
    {

    }

    public interface ISigned : IIntegral
    {

    }

    public interface ISigned<S> : ISigned, IIntegral<S>
        where S : unmanaged
    {

    }

    public interface IBlock : ICellular
    {
        ByteSize IType.StorageSize
            => ((ByteSize)CellWidth)*CellCount;
    }

    public interface IBlock<T> : IBlock
        where T : unmanaged
    {
        ref T this[uint cell] {get;}

        BitWidth ICellular.CellWidth
            => width<T>();
    }

    public interface IIndexed : ICellular
    {
        uint N {get;}

        uint ICellular.CellCount
            => N;
    }

    public interface IIndexed<T> : IIndexed
        where T : unmanaged
    {
        BitWidth ICellular.CellWidth
            => width<T>();
    }

    public interface IVector : IIndexed
    {

    }

    public interface IVector<S> : IVector, IType<S>
        where S : unmanaged
    {
        BitWidth IType.DataWidth
            => N*CellWidth;
    }

    public interface IVector<S,T> : IVector<S>
        where S : unmanaged
        where T : unmanaged
    {
        ref T this[uint cell] {get;}
    }

    public interface IArray : IIndexed
    {

    }

    public interface IArray<T> : IArray
        where T : unmanaged
    {
        ref T this[uint cell] {get;}

        BitWidth IType.DataWidth
            => N*width<T>();
    }

    public interface IGrid : IType
    {
        uint M {get;}

        uint N {get;}

        BitWidth IType.DataWidth
            => M*N;
    }

    public interface IGrid<S> : IGrid, IType<S>
        where S : unmanaged
    {
    }

    public interface IGrid<S,T> : IGrid<S>
        where S : unmanaged
        where T : unmanaged
    {
        ref T this[uint row] {get;}
    }

    public interface IMap<S,T> : IType
        where S : unmanaged, IType
        where T : unmanaged, IType
    {
        S Source {get;}

        T Target {get;}

        ByteSize IType.StorageSize
            => size<S>() + size<T>();

        BitWidth IType.DataWidth
            => Source.DataWidth + Target.DataWidth;
    }
}