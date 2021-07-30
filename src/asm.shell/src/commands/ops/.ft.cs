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
    using static Relations;

    using C = AsmCodes.RexPrefixCode;

    public readonly struct TmpTables
    {
        const byte PointCount = 5;

        public static ReadOnlySpan<C> Source => new C[PointCount]{C.Base,C.B,C.X,C.R,C.W};

        public static ReadOnlySpan<AsciCode> Target => new AsciCode[PointCount]{AsciCode.Bang, AsciCode.B, AsciCode.X, AsciCode.R, AsciCode.W};
    }

    partial class AsmCmdService
    {
        [CmdOp(".ft")]
        unsafe Outcome FT(CmdArgs args)
        {
            var src = recover<C,byte>(Source);
            var dst = recover<AsciCode,byte>(Target);
            var ax = address(first(Source));
            var ay = address(first(Target));
            var ft = FunctionTables.f8(ax, ay).Define(src, dst);

            byte x = 0;
            char y = '\0';

            x = skip(src,0);
            y = (char)ft.Fx(x);
            Write(arrow(x,y));

            x = skip(src,1);
            y = (char)ft.Fx(x);
            Write(arrow(x,y));

            x = skip(src,2);
            y = (char)ft.Fx(x);
            Write(arrow(x,y));

            x = skip(src,3);
            y = (char)ft.Fx(x);
            Write(arrow(x,y));

            x = skip(src,4);
            y = (char)ft.Fx(x);
            Write(arrow(x,y));

            return true;
        }
    }
}