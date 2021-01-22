//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmLang.SizeQualifiers;

    using SQ = AsmLang.SizeQualifiers;

    partial struct AsmLang
    {
        public static SQ.Byte @byte()
            => default;

        public static Word word()
            => default;

        public static DWord dword()
            => default;

        [Op]
        public static QWord qword()
            => default;

        [Op]
        public static XmmWord xmmword()
            => default;

        [Op]
        public static YmmWord ymmword()
            => default;

        [Op]
        public static ZmmWord zmmword()
            => default;
    }
}