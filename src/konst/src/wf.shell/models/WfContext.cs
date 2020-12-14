//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct WfContext : IWfContext
    {
        public IWfAppPaths Paths {get; internal set;}

        public IApiParts ApiParts {get; internal set;}

        public IJsonSettings Settings {get; internal set;}

        public string[] Args {get; internal set;}

        public WfController Controller {get; internal set;}
    }
}