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
        /// <summary>
        /// Specifies that a <typeparamref name='T'/> sequence is partitioned by a specific <typeparamref name='T'/> element
        /// </summary>
        public readonly struct SeqSplit<T> : IRule<SeqSplit<T>,T>
        {
            public T Delimiter {get;}

            [MethodImpl(Inline)]
            public SeqSplit(T delimiter)
            {
                Delimiter = delimiter;
            }
        }
    }
}