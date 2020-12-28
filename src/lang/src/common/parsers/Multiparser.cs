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
    using static z;

    [ApiType]
    public struct Multiparser
    {
        [FixedAddressValueType]
        static Multiparser _Service;

        Dictionary<ClrToken,IParser> Parsers;

        static Multiparser()
        {
            _Service = new Multiparser();
            _Service.Parsers = dict<ClrToken,IParser>();
            _Service.Include(FilePathParser.service());
        }

        [MethodImpl(Inline)]
        public static ref Multiparser service()
            => ref address(_Service).Ref<Multiparser>();

        [MethodImpl(Inline)]
        public void Include(IParser parser)
            => Parsers[parser.TargetType] = parser;

        [MethodImpl(Inline)]
        public bool Lookup(Type target, out IParser parser)
            => Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool Lookup(ClrToken target, out IParser parser)
            => Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool CanParse(Type target)
            => Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public bool CanParse(ClrToken target)
            => Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public IParser Require(Type target)
            => Parsers[target];

        [MethodImpl(Inline)]
        public IParser Require(ClrToken target)
            => Parsers[target];
    }
}