//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ProjectRunner
    {
        public static class MessageType
        {
            public const string SessionStart = "TestSession.Start";

            public const string SessionEnd = "TestSession.Terminate";

            public const string SessionAbort = "TestSession.Abort";

            public const string SessionConnected = "TestSession.Connected";

            public const string TestMessage = "TestSession.Message";

            public const string VersionCheck = "ProtocolVersion";

            public const string ProtocolError = "ProtocolError";

            public const string DiscoveryInitialize = "TestDiscovery.Initialize";

            public const string StartDiscovery = "TestDiscovery.Start";

            public const string TestCasesFound = "TestDiscovery.TestFound";

            public const string DiscoveryComplete = "TestDiscovery.Completed";

            public const string CancelDiscovery = "TestDiscovery.Cancel";

            public const string ExecutionInitialize = "TestExecution.Initialize";

            public const string CancelTestRun = "TestExecution.Cancel";

            public const string AbortTestRun = "TestExecution.Abort";

            public const string StartTestExecutionWithSources = "TestExecution.StartWithSources";

            public const string StartTestExecutionWithTests = "TestExecution.StartWithTests";

            public const string TestRunStatsChange = "TestExecution.StatsChange";

            public const string ExecutionComplete = "TestExecution.Completed";

            public const string GetTestRunnerProcessStartInfoForRunAll = "TestExecution.GetTestRunnerProcessStartInfoForRunAll";

            public const string GetTestRunnerProcessStartInfoForRunSelected = "TestExecution.GetTestRunnerProcessStartInfoForRunSelected";

            public const string CustomTestHostLaunch = "TestExecution.CustomTestHostLaunch";

            public const string CustomTestHostLaunchCallback = "TestExecution.CustomTestHostLaunchCallback";

            public const string ExtensionsInitialize = "Extensions.Initialize";

            public const string TestRunAllSourcesWithDefaultHost = "TestExecution.RunAllWithDefaultHost";

            public const string TestRunSelectedTestCasesDefaultHost = "TestExecution.RunSelectedWithDefaultHost";

            public const string LaunchAdapterProcessWithDebuggerAttached = "TestExecution.LaunchAdapterProcessWithDebuggerAttached";

            public const string LaunchAdapterProcessWithDebuggerAttachedCallback = "TestExecution.LaunchAdapterProcessWithDebuggerAttachedCallback";

            public const string DataCollectionMessage = "DataCollection.SendMessage";

            public const string TestHostLaunched = "DataCollection.TestHostLaunched";

            public const string BeforeTestRunStart = "DataCollection.BeforeTestRunStart";

            public const string BeforeTestRunStartResult = "DataCollection.BeforeTestRunStartResult";

            public const string AfterTestRunEnd = "DataCollection.AfterTestRunEnd";

            public const string AfterTestRunEndResult = "DataCollection.AfterTestRunEndResult";

            public const string DataCollectionTestStart = "DataCollection.TestStart";

            public const string DataCollectionTestEnd = "DataCollection.TestEnd";

            public const string DataCollectionTestEndResult = "DataCollection.TestEndResult";

            public const string DataCollectionTestStartAck = "DataCollection.TestStartAck";
        }
    }
}