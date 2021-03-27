//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct Prototypes
    {
        [Op]
        public static byte range_check(byte[] src)
            => src[3];

        const string prototypes = nameof(prototypes);

        const string eval = nameof(eval);

        const string contract = nameof(contract);

        const string client = nameof(client);

        const string loops = nameof(loops);

        const string dot = ".";
    }
}