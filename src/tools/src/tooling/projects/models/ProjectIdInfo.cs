//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.CodeAnalysis;
    using System.Collections.Generic;

    partial struct CodeProjects
    {
        public class ProjectIdInfo
        {
            public ProjectIdInfo(ProjectId id, bool isDefinedInSolution)
            {
                Id = id ?? throw new ArgumentNullException(nameof(id));
                IsDefinedInSolution = isDefinedInSolution;
            }

            public ProjectId Id {get;set;}

            public bool IsDefinedInSolution {get;set;}

            /// <summary>
            /// Project configurations as defined in solution.
            /// Keys are solution build configuration in '$(Configuration)|$(Platform)' format,
            /// values are according project configurations. Null if there is no solution.
            /// </summary>
            public IReadOnlyDictionary<string, string> SolutionConfiguration { get; set; }
        }
    }
}