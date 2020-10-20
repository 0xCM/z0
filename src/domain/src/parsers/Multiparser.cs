//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiDataType]
    public struct Multiparser
    {
        [FixedAddressValueType]
        static Multiparser _Service;

        Dictionary<ClrArtifactKey,IParseFunction> Parsers;

        static Multiparser()
        {
            _Service = new Multiparser();
            _Service.Parsers = dict<ClrArtifactKey,IParseFunction>();
            _Service.Include(FilePathParser.service());
        }

        [MethodImpl(Inline)]
        public static ref Multiparser service()
            => ref address(_Service).Ref<Multiparser>();

        [MethodImpl(Inline)]
        public void Include(IParseFunction parser)
            => Parsers[parser.TargetType] = parser;

        [MethodImpl(Inline)]
        public bool Lookup(Type target, out IParseFunction parser)
            => Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool Lookup(ClrArtifactKey target, out IParseFunction parser)
            => Parsers.TryGetValue(target, out parser);

        [MethodImpl(Inline)]
        public bool CanParse(Type target)
            => Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public bool CanParse(ClrArtifactKey target)
            => Parsers.ContainsKey(target);

        [MethodImpl(Inline)]
        public IParseFunction Require(Type target)
            => Parsers[target];

        [MethodImpl(Inline)]
        public IParseFunction Require(ClrArtifactKey target)
            => Parsers[target];
    }
}