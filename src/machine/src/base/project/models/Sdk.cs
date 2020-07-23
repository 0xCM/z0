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
        public readonly struct Sdk
        {
            public readonly string Name;
            
            const string TagName = nameof(Sdk);

            [MethodImpl(Inline)]
            public Sdk(string name)
            {
                Name = name;
            }
        }
    }
}