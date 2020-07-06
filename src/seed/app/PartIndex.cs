//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartIndex : IEnumerable<IPart>
    {
        internal readonly Dictionary<PartId,IPart> Data;

        [MethodImpl(Inline)]
        internal PartIndex(Dictionary<PartId,IPart> src)
            => Data = src;
        
        public int PartCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
        
        public IEnumerator<IPart> GetEnumerator()
            => Data.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}