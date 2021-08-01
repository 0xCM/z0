//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static TmpTables;

    using C = AsmCodes.RexPrefixCode;

    public readonly struct TmpTables
    {
        const byte PointCount = 5;

        public static ReadOnlySpan<C> Source
            => new C[PointCount]{C.Base,C.B,C.X,C.R,C.W};

        public static ReadOnlySpan<AsciCode> Target
            => new AsciCode[PointCount]{AsciCode.Bang, AsciCode.B, AsciCode.X, AsciCode.R, AsciCode.W};
    }

    partial class AsmCmdService
    {
        [CmdOp(".ft")]
        unsafe Outcome FT(CmdArgs args)
        {
            var src = recover<C,byte>(Source);
            Blit.fx8<AsciCode>(src, Target, out var f);

            byte x = 0;

            x = skip(src,0);
            Write(f.map(x));

            x = skip(src,1);
            Write(f.map(x));

            x = skip(src,2);
            Write(f.map(x));

            x = skip(src,3);
            Write(f.map(x));

            x = skip(src,4);
            Write(f.map(x));

            return true;
        }
    }
}