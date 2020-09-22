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
        public static ApiCodeBlock define(OpUri uri, MemoryAddress address, in BinaryCode data)
            => new ApiCodeBlock(uri, new BasedCodeBlock(address, data));

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock define(OpUri uri, in BasedCodeBlock data)
            => new ApiCodeBlock(uri, data);

        [MethodImpl(Inline), Op]
        public static BasedCodeBlock define(MemoryAddress address, in BinaryCode code)
            => new BasedCodeBlock(address, code);

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock define(MemoryAddress address, OpUri uri, in BinaryCode data)
            => new ApiCodeBlock(address, uri, data);

        [MethodImpl(Inline), Op]
        public static BinaryCode define(byte[] data)
            => new BinaryCode(data);

        [MethodImpl(Inline), Op]
        public static ApiMemberCode define(in ApiMember member, in ApiCodeBlock data)
            => new ApiMemberCode(member, data);

        [MethodImpl(Inline), Op]
        public static ApiCapture define(OpIdentity id, MethodInfo method, BasedCodeBlock extracted, BasedCodeBlock parsed, ExtractTermCode term)
            => new ApiCapture(id, method, extracted, parsed, term);
    }
}