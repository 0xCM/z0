//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MetadataAddressPair
    {
        public readonly MemoryAddress Subject;

        public readonly MemoryAddress Owner;

        [MethodImpl(Inline)]
        public MetadataAddressPair(MemoryAddress subject, MemoryAddress owner)
        {
            Subject = subject;
            Owner = owner;
        }        
    }
}