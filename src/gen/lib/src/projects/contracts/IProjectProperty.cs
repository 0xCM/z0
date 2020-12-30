//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IProjectProperty : IProjectElement
    {
        string Value {get;}
    }

    public interface IProjectProperty<F> : IProjectProperty, IProjectElement<F>
        where F : struct, IProjectProperty<F>
    {

    }
}