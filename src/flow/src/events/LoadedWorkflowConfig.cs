//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LoadedWorkflowConfig : IWorkflowEvent<LoadedWorkflowConfig>
    {
        const string Pattern = "{0}: Loaded workflow configuration from {1}";
        
        public readonly FilePath ConfigPath;

        public readonly WorkflowConfig ConfigData;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public LoadedWorkflowConfig(FilePath src, WorkflowConfig data)
        {
            ConfigPath = src;
            ConfigData = data;
            Timestamp = z.now();
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Timestamp, ConfigPath);
        
        public string Description
            => Format();
    }
}