//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Part;

    public interface IProjectElement : ITextual
    {
        Name Name {get;}

    }

    public interface IProjectElement<F> : IProjectElement
        where F : struct, IProjectElement<F>
    {

    }
}