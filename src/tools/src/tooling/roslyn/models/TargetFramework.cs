//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using NuGet.Frameworks;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct CodeProjects
    {
        public class TargetFramework
        {
            public string Name {get;}

            public string FriendlyName {get;}

            public string ShortName {get;}

            [MethodImpl(Inline)]
            public TargetFramework(NuGetFramework framework)
            {
                Name = framework.Framework;
                FriendlyName = framework.Framework;
                ShortName = framework.GetShortFolderName();
            }

            public string Format()
                => ShortName;

            public override string ToString()
                => Format();
        }

    }
}