//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct WfContext : IWfContext
    {
        internal IWfPaths Paths;

        internal IApiParts ApiParts;

        internal ITestLogPaths TestLogPaths;

        internal WfSettings WfSettings;

        internal IJsonSettings Settings;

        internal AppArgs Args;

        internal WfController Controller;

        IWfPaths IWfContext.Paths
            => Paths;

        IApiParts IWfContext.ApiParts
            => ApiParts;

        ITestLogPaths IWfContext.TestLogPaths
            => TestLogPaths;

        IJsonSettings IWfContext.Settings
            => Settings;

        AppArgs IWfContext.Args
            => Args;

        WfController IWfContext.Controller
            => Controller;
    }
}