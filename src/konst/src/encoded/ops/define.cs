//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Encoded
    {
        [MethodImpl(Inline), Op]
        public static MemberCode define(OpUri uri, MemoryAddress address, in BinaryCode data)
            => new MemberCode(uri, new LocatedCode(address, data));

        [MethodImpl(Inline), Op]
        public static MemberCode define(OpUri uri, in LocatedCode data)
            => new MemberCode(uri, data);

        /// <summary>
        /// Defines uri bits with a potentially bad uri (for diagnostic purposes)
        /// </summary>
        /// <param name="perhaps">The uri, perhaps</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline), Op]
        public static IdentifiedCode define(ParseResult<OpUri> perhaps, BinaryCode src)
            => perhaps.MapValueOrSource(
                    uri => new IdentifiedCode(uri,src), 
                    baduri => new IdentifiedCode(baduri, src)
                    );

        [MethodImpl(Inline), Op]
        public static LocatedCode define(MemoryAddress address, in BinaryCode code)
            => new LocatedCode(address, code);       

        [MethodImpl(Inline), Op]
        public static IdentifiedCode define(OpUri uri, in BinaryCode data)
            => new IdentifiedCode(uri, data);

        [MethodImpl(Inline), Op]
        public static BinaryCode define(byte[] data)
            => new BinaryCode(data);

        [MethodImpl(Inline), Op]
        public static ApiCode define(in ApiMember member, in IdentifiedCode data)
            => new ApiCode(member, data);

        [MethodImpl(Inline), Op]
        public static CapturedCode define(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
            => new CapturedCode(id, src, method, extracted, parsed, term);
    }
}