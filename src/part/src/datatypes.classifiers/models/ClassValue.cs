//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClassValue<K> : IClassValue<K>
    {
        public Label Name {get;}

        public K Class {get;}

        [MethodImpl(Inline)]
        public ClassValue(Label name, K @class)
        {
            Name = name;
            Class = @class;
        }
    }
}