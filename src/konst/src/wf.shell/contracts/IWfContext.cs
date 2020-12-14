//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWfContext : ITextual
    {
        IWfAppPaths Paths {get;}

        IJsonSettings Settings {get;}

        IApiParts ApiParts {get;}

        WfController Controller {get;}

        string[] Args {get;}

        CorrelationToken Ct
            => z.correlate(Controller.Id);

        string AppName
            => Controller.Name;

        string ITextual.Format()
            => AppName;
    }

    public interface IWfContext<S> : IWfContext
    {
        S State {get;}
    }
}