//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ProjectModel
    {
        public readonly struct Property
        {
            public string Name {get;}

            public string Value {get;}

            [MethodImpl(Inline)]
            public Property(string name, string value)
            {
                Name = name;
                Value = value;
            }
        }
    }
}