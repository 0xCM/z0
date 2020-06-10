//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    class AspectLabels
    {
        public const string mem = nameof(mem);

        public const string size = nameof(size);

        public const string @base = nameof(@base);

        public const string scale = nameof(scale);

        public const string index = nameof(index);

        public const string dx = nameof(dx);

        public const string seg = nameof(seg);

        public const string prefix = nameof(prefix);

        public const string rel = nameof(rel);

        public const string reladdr = nameof(reladdr);

        public const string near = nameof(near);

        public const string far = nameof(far);
    }

}