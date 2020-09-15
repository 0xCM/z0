//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        /// <summary>
        /// Creates an index over the known parts
        /// </summary>
        [Op]
        public static PartIndex index()
            => index(modules().Parts);

        public static PartIndex index(IPart[] src)
        {
            var dst = new Dictionary<PartId,IPart>();
            foreach(var part in src)
                dst.TryAdd(part.Id, part);
            return new PartIndex(dst);
        }
    }
}