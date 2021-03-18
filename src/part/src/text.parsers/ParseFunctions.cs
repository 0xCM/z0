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

    [ApiHost]
    public class ParseFunctions
    {
        Dictionary<Type,IParseFunction> _Parsers;

        public ParseFunctions()
        {
            _Parsers = root.dict<Type,IParseFunction>();
        }

        public ParseFunctions(Index<IParseFunction> src)
            : this()
        {
            root.iter(src, Include);
        }

        [Op, Closures(UnsignedInts)]
        public bool Parse<T>(string src, out T dst)
        {
            if(Lookup(typeof(T), out var parser))
            {
                if(parser.Parse(src, out var parsed))
                {
                    dst = (T)parsed;
                    return true;
                }
            }
            dst = default;
            return false;
        }

        [MethodImpl(Inline)]
        public void Include<T>(ParseFunction<T> parser)
            => _Parsers[typeof(T)] = Parsers.create(parser);

        [MethodImpl(Inline)]
        public void Include(IParseFunction parser)
            => _Parsers[parser.TargetType] = parser;

        [MethodImpl(Inline)]
        public bool Lookup(Type target, out IParseFunction parser)
            => _Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool CanParse(Type target)
            => _Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public IParseFunction Require(Type target)
            => _Parsers[target];
    }
}