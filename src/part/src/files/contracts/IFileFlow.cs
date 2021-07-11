//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFileFlow : IDataFlow<TypedFile,TypedFile>
    {

    }

    public interface IFileFlow<S,T> : IFileFlow
        where S : struct, IFileType<S>
        where T : struct, IFileType<T>
    {

        new TypedFile<S> Source {get;}

        new TypedFile<T> Target {get;}

        TypedFile IArrow<TypedFile,TypedFile>.Source
            => Source;

        TypedFile IArrow<TypedFile,TypedFile>.Target
            => Target;
    }
}