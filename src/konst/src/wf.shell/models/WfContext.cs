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

        internal string[] Args;

        internal WfController Controller;

        IWfPaths IWfContext.Paths => Paths;

        IApiParts IWfContext.ApiParts => ApiParts;

        ITestLogPaths IWfContext.TestLogPaths => TestLogPaths;

        IJsonSettings IWfContext.Settings => Settings;

        string[] IWfContext.Args => Args;

        WfController IWfContext.Controller => Controller;
    }
}