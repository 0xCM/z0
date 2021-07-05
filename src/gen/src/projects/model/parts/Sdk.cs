//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ProjectModel
    {
        public readonly struct Sdk
        {
            public Name Name {get;}

            const string TagName = nameof(Sdk);

            [MethodImpl(Inline)]
            public Sdk(Name name)
            {
                Name = name;
            }
        }
    }
}