//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDataTypes;

    using SQ = AsmDataTypes;


    partial struct asm
    {
        [Op]
        public static SQ.Byte @byte()
            => default;

        [Op]
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