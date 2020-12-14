//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using LU = System.Collections.Generic.Dictionary<ApiHostUri,ApiHostCodeBlocks>;

    public sealed class ApiHostCodeLookup : LU
    {
        public static ApiHostCodeLookup create(LU src)
            => new ApiHostCodeLookup(src);

        public static ApiHostCodeLookup create()
            => new ApiHostCodeLookup();

        public ApiHostCodeLookup()
        {

        }

        ApiHostCodeLookup(LU src)
            : base(src)
        {

        }

        public static ApiHostCodeLookup Empty
            => create();
    }
}