//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ProjectModel;

    partial struct ProjectModel
    {
        public readonly struct OutputTypes
        {
            public const string Library = nameof(Library);

            public const string Exe = nameof(Exe);            
        }
    }
}