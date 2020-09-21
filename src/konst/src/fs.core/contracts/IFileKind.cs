//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    public interface IFileKind : ITextual
    {
        string Name {get;}

        string ITextual.Format()
            => Name;
    }

    public interface IFileKind<F> : IFileKind
        where F : struct, IFileKind<F>
    {
        string IFileKind.Name
            => typeof(F).Name;
    }
}