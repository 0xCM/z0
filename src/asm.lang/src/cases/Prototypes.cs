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
        public static ref byte range_check(byte[] src)
            => ref memory.seek(src,3);

        const string prototypes = nameof(prototypes);

        const string eval = nameof(eval);

        const string evaluator = nameof(evaluator);

        const string contracted = nameof(contracted);

        const string client = nameof(client);

        const string loops = nameof(loops);

        const string branches = nameof(branches);

        const string extensions = nameof(extensions);

        const string @switch = nameof(@switch);

        const string nested = nameof(nested);

        const string dot = ".";

        [ApiHost(prototypes + dot + branches)]
        public readonly partial struct Branches
        {
        }
    }
}