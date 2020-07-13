//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MetadataSubjectIndex : IIndex<MetadataSubjectIndex,MetadataSubject>
    {
        readonly MetadataSubject[] Data;

        [MethodImpl(Inline)]
        public static implicit operator MetadataSubjectIndex(MetadataSubject[] src)
            => new MetadataSubjectIndex(src);
        
        [MethodImpl(Inline)]
        public MetadataSubjectIndex(MetadataSubject[] src)
            => Data = src;
        
        public MetadataSubject[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}