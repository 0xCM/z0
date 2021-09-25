//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;


    using static Root;

    public readonly struct MatchResult
    {
        readonly IMatcher Matcher;

        readonly ulong Data;

        [MethodImpl(Inline)]
        internal MatchResult(IMatcher matcher, ulong data)
        {
            Matcher = matcher;
            Data = data;
        }

        public bool Suceeded
        {
            [MethodImpl(Inline)]
            get => bit.test(Data,63);
        }
    }
}