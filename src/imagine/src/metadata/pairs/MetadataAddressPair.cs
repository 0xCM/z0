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
        [MethodImpl(Inline)]
        public MetadataAddressPair(MemoryAddress Subject, MemoryAddress Owner)
        {
            this.Subject = Subject;
            this.Owner = Owner;
        }
        
        public MemoryAddress Subject {get;}

        public MemoryAddress Owner {get;}

    }
}