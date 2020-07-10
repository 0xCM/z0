//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;

    public readonly struct Needs
    {
        [MethodImpl(Inline)]
        public static NeededPart<P> needs<P>(P client, P supplier)
            where P : unmanaged, Enum
                => (client,supplier);

        [MethodImpl(Inline)]
        public static NeededParts<P> needs<P>(P client, params P[] suppliers)
            where P : unmanaged, Enum
                => new NeededParts<P>(client,suppliers);

        [MethodImpl(Inline)]
        public static NeededPart<PartId> needs(PartId client, PartId supplier)
            => (client, supplier);

        [MethodImpl(Inline)]
        public static bool deposit(in NeededParts<PartId> src)
        {
            return NeedStore.TryAdd(src.Client,src);
        }

        [MethodImpl(Inline)]
        public static ref readonly NeededParts<PartId> deposit(in NeededParts<PartId> src, out bool stored)
        {
            stored = NeedStore.TryAdd(src.Client,src);
            return ref src;
        }
        
        static readonly ConcurrentDictionary<PartId, NeededParts<PartId>> NeedStore
            = new ConcurrentDictionary<PartId, NeededParts<PartId>>();
    }
}