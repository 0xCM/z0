//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = AsmRegs;

    [ApiComplete]
    public struct AsmRegLookup
    {
        Index<Register> _Gp8;

        Index<Register> _Gp16;

        Index<Register> _Gp32;

        Index<Register> _Gp64;

        Index<Register> _Xmm;

        Index<Register> _Ymm;

        Index<Register> _Zmm;

        public ReadOnlySpan<Register> Gp8
        {
            [MethodImpl(Inline)]
            get => _Gp8.View;
        }

        public ReadOnlySpan<Register> Gp16
        {
            [MethodImpl(Inline)]
            get => _Gp16.View;
        }

        public ReadOnlySpan<Register> Gp32
        {
            [MethodImpl(Inline)]
            get => _Gp32;
        }

        public ReadOnlySpan<Register> Gp64
        {
            [MethodImpl(Inline)]
            get => _Gp64.View;
        }

        public ReadOnlySpan<Register> Xmm
        {
            [MethodImpl(Inline)]
            get => _Xmm.View;
        }

        public ReadOnlySpan<Register> Ymm
        {
            [MethodImpl(Inline)]
            get => _Ymm.View;
        }

        public ReadOnlySpan<Register> Zmm
        {
            [MethodImpl(Inline)]
            get => _Zmm.View;
        }

        [MethodImpl(Inline)]
        public static AsmRegLookup create(Index<Register> src)
        {
            var dst = new AsmRegLookup();
            dst._Gp8 = api.Gp8Filter(src);
            dst._Gp16 = api.Gp16Filter(src);
            dst._Gp32 = api.Gp32Filter(src);
            dst._Gp64 = api.Gp64Filter(src);
            dst._Xmm  = api.XmmFilter(src);
            dst._Ymm  = api.YmmFilter(src);
            dst._Zmm = api.ZmmFilter(src);
            return dst;
        }
    }
}