//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MetadataNamePair
    {
        public readonly  StringRef Subject;

        public readonly StringRef Owner;
        
        [MethodImpl(Inline)]
        public MetadataNamePair(StringRef subject, StringRef owner)
        {
            Subject = subject;
            Owner = owner;
        }
    }
}