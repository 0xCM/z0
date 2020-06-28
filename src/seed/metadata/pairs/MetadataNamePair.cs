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
        [MethodImpl(Inline)]
        public MetadataNamePair(asci64 Subject, asci64 Owner)
        {
            this.Subject = Subject;
            this.Owner = Owner;
        }

        public asci64 Subject {get;}

        public asci64 Owner {get;}

    }

}