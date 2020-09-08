//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FS;

    public interface IFileModule : ITextual
    {
        FS.FilePath Path {get;}

        ModuleKind Kind {get;}

        string ITextual.Format()
            => Path.Name;
    }

    public interface IFileModule<T> : IFileModule
        where T : struct, IFileModule<T>
    {

    }

    public interface IFileModule<F,T> : IFileModule<T>
        where F : struct, IFileModule<F,T>
        where T : struct, IFileModule<T>
    {

    }
}