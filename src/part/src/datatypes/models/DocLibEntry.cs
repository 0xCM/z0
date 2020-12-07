//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct DocLibEntry
    {
        public string Name {get;}

        public string Type {get;}

        [MethodImpl(Inline)]
        public DocLibEntry(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Format()
            => string.Format("{0,-16} | {1}", Type, Name);
    }
}