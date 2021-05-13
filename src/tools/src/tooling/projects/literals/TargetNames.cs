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
        public readonly struct TargetNames
        {
            public const string Compile = nameof(Compile);

            public const string CoreCompile = nameof(CoreCompile);

            public const string ResolveReferences = nameof(ResolveReferences);
        }
    }
}
