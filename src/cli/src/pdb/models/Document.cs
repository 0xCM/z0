//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct PdbServices
    {
        public readonly struct Document
        {
            public string Name {get;}

            public Guid Type {get;}

            public Document(string name, Guid type)
            {
                Name = name;
                Type = type;
            }
        }
    }
}