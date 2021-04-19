//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public readonly partial struct Prototypes
    {
        [Op]
        public static ref byte range_check(byte[] src)
            => ref memory.seek(src,3);

        const string dot = ".";

        const string prototypes = nameof(prototypes) + dot;

        const string eval = nameof(eval);

        const string evaluator = nameof(evaluator);

        const string contracted = nameof(contracted);

        const string client = nameof(client);

        const string loops = nameof(loops);

        const string branches = nameof(branches);

        const string extensions = nameof(extensions);

        const string store = nameof(store);

        const string @switch = nameof(@switch);

        const string nested = nameof(nested);

        const string vcopy = nameof(vcopy);

        const string calls = nameof(calls);

        const string targets = nameof(targets);

        public const string calc8 = nameof(calc8);

        public const string calc64 = nameof(calc64);

        [ApiHost(prototypes + branches)]
        public readonly partial struct Branches
        {
        }
    }
}