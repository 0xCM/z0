//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Gen.Projects
{
    public interface IProjectGroup
    {
        GroupKind GroupKind {get;}

        void Render(uint margin, ITextBuffer dst);
    }

    public interface IProjectGroup<T> : IProjectGroup
        where T : IProjectElement
    {
        DataList<T> Members {get;}
    }
}