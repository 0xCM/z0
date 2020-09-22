//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Text;

    using static Konst;

    partial struct EncodedX86
    {
        [MethodImpl(Inline), Op]
        public static ApiHex define(OpUri uri, MemoryAddress address, in BinaryCode data)
            => new ApiHex(uri, new BasedCodeBlock(address, data));

        [MethodImpl(Inline), Op]
        public static ApiHex define(OpUri uri, in BasedCodeBlock data)
            => new ApiHex(uri, data);

        [MethodImpl(Inline), Op]
        public static BasedCodeBlock define(MemoryAddress address, in BinaryCode code)
            => new BasedCodeBlock(address, code);

        [MethodImpl(Inline), Op]
        public static ApiHex define(MemoryAddress address, OpUri uri, in BinaryCode data)
            => new ApiHex(address, uri, data);

        [MethodImpl(Inline), Op]
        public static BinaryCode define(byte[] data)
            => new BinaryCode(data);

        [MethodImpl(Inline), Op]
        public static ApiMemberHex define(in ApiMember member, in ApiHex data)
            => new ApiMemberHex(member, data);

        [MethodImpl(Inline), Op]
        public static ApiCapture define(OpIdentity id, MethodInfo method, BasedCodeBlock extracted, BasedCodeBlock parsed, ExtractTermCode term)
            => new ApiCapture(id, method, extracted, parsed, term);
    }
}