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
        public sealed class ProjectSectionBlock : SectionBlock
        {
            private ProjectSectionBlock(string name, ImmutableArray<Property> properties)
                : base(name, properties)
            {
            }

            public static ProjectSectionBlock Parse(string headerLine, Scanner scanner)
            {
                var (name, properties) = ParseNameAndProperties(
                    "ProjectSection", "EndProjectSection", headerLine, scanner);

                return new ProjectSectionBlock(name, properties);
            }
        }
    }
}