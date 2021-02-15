//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    [ApiComplete]
    public class ParseFunctions
    {
        Dictionary<ClrToken,IParseFunction> Parsers;

        public ParseFunctions()
        {
            Parsers = root.dict<ClrToken,IParseFunction>();
        }

        public ParseFunctions(Index<IParseFunction> src)
            : this()
        {
            root.iter(src, Include);
        }

        [MethodImpl(Inline)]
        public void Include(IParseFunction parser)
            => Parsers[parser.TargetType] = parser;

        [MethodImpl(Inline)]
        public bool Lookup(Type target, out IParseFunction parser)
            => Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool Lookup(ClrToken target, out IParseFunction parser)
            => Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool CanParse(Type target)
            => Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public bool CanParse(ClrToken target)
            => Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public IParseFunction Require(Type target)
            => Parsers[target];

        [MethodImpl(Inline)]
        public IParseFunction Require(ClrToken target)
            => Parsers[target];
    }
}