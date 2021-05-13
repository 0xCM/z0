//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Immutable;

    partial struct CodeSolutions
    {
        public sealed class GlobalSectionBlock : SectionBlock
        {
            private GlobalSectionBlock(string name, ImmutableArray<Property> properties)
                : base(name, properties)
            {
            }

            public static GlobalSectionBlock Parse(string headerLine, Scanner scanner)
            {
                var (name, properties) = ParseNameAndProperties(
                    "GlobalSection", "EndGlobalSection", headerLine, scanner);

                return new GlobalSectionBlock(name, properties);
            }
        }
    }
}
