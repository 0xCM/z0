//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiType]
    public struct RegisterLookup
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

        public IndexedView<Register> Gp32
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

        public static RegisterLookup create()
        {
            var dst = new RegisterLookup();
            var source = Registers.All();
            dst._Gp8 = Registers.Gp8(source);
            dst._Gp16 = Registers.Gp16(source);
            dst._Gp32 = Registers.Gp32(source);
            dst._Gp64 = Registers.Gp64(source);
            dst._Xmm  = Registers.Xmm(source);
            dst._Ymm  = Registers.Ymm(source);
            dst._Zmm = Registers.Zmm(source);
            return dst;
        }
    }
}