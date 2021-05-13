//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct CodeProjects
    {
        [LiteralProvider]
        public readonly struct MetadataNames
        {
            public const string FullPath = nameof(FullPath);

            public const string IsImplicitlyDefined = nameof(IsImplicitlyDefined);

            public const string Project = nameof(Project);

            public const string ProjectReferenceOriginalItemSpec = nameof(ProjectReferenceOriginalItemSpec);

            public const string ReferenceSourceTarget = nameof(ReferenceSourceTarget);

            public const string Version = nameof(Version);

            public const string Aliases = nameof(Aliases);
        }
    }
}