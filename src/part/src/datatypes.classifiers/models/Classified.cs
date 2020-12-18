//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Classified<K> : IClassified<ClassValue<K>>
    {
        public ClassValue<K> Class {get;}

        [MethodImpl(Inline)]
        public Classified(ClassValue<K> @class)
            => Class = @class;
    }
}