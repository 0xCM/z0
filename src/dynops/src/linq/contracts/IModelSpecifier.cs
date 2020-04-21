//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    public interface IModelSpecifier
    {
        object SpecifyModel();
    }

    public interface IModelSpecifier<out M> : IModelSpecifier
    {
        new M SpecifyModel();
    }
}