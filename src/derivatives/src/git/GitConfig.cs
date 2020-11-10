//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Git
{
    using System.IO;

    public static class GitConfig
    {
        public const string ScalarPrefix = "scalar.";

        public const string MaxRetriesConfig = ScalarPrefix + "max-retries";

        public const string TimeoutSecondsConfig = ScalarPrefix + "timeout-seconds";

        public const string GitStatusCacheBackoffConfig = ScalarPrefix + "status-cache-backoff-seconds";

        public const string EnlistmentId = ScalarPrefix + "enlistment-id";

        public const string CacheServer = "gvfs.cache-server";

        public const string ObjectCache = "gvfs.sharedCache";

        public const string ScalarTelemetryId = GitConfig.ScalarPrefix + "telemetry-id";

        public const string ScalarTelemetryPipe = GitConfig.ScalarPrefix + "telemetry-pipe";

        public const string IKey = GitConfig.ScalarPrefix + "ikey";

        public const string HooksExtension = ".hooks";

        public const string UseGvfsHelper = "core.useGvfsHelper";
    }
}