//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MetadataPair<T>
        where T : struct
    {
        public readonly T Subject;

        public readonly T Owner;

        [MethodImpl(Inline)]
        public static implicit operator MetadataPair<T>(in ConstPair<T> src)
            => new MetadataPair<T>(src.Left, src.Right);
        
        [MethodImpl(Inline)]
        public MetadataPair(in T subject, in T owner)
        {
            Subject = subject;
            Owner = owner;
        }    
    }
}