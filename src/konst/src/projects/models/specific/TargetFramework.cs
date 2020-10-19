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

    partial struct ProjectModel
    {
        public readonly struct TargetFramework : IProjectProperty<TargetFramework>
        {
            public readonly string Value;

            public const string TagName = nameof(TargetFramework);

            [MethodImpl(Inline)]
            public TargetFramework(string value)
                => Value = value;

            [MethodImpl(Inline)]
            public TargetFramework(string value, Version ver)
                => Value = value + ver.Format();

            string IProjectElement.Name
                => TagName;

            string IProjectProperty.Value
                => Value;
        }       
    }
}