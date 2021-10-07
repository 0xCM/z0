//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public readonly struct Substitutions<T>
        {
            public uint Count {get;}

            readonly Index<T> Sources {get;}

            readonly Index<T> Targets {get;}

            [MethodImpl(Inline)]
            internal Substitutions(uint count, T[] sources, T[] targets)
            {
                Count = count;
                Sources = sources;
                Targets = targets;
            }

            [MethodImpl(Inline)]
            public ref readonly T Source(uint index)
                => ref Sources[index];

            [MethodImpl(Inline)]
            public ref readonly T Target(uint index)
                => ref Targets[index];
        }
    }
}