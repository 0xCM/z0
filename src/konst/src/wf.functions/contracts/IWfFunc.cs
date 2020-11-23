//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfFunc : ITextual
    {
        WfStepId StepId {get;}

        StringRef Name {get;}

        string ITextual.Format()
            => text.format("{0}/{1}", StepId.Format(), Name.Format());
    }

    [Free]
    public interface IWfFunc<C> : IWfFunc
        where C : IWfStep<C>, new()
    {
        C Step => default;
    }
}