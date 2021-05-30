//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public unsafe readonly struct RegKindConverter
    {
        [Op]
        public static RegKindConverter create()
        {
            var pIce = pvoid(RegConversionData.IceRegisters);
            var pKind = pvoid(RegConversionData.Kinds);
            return new RegKindConverter(pIce, pKind);
        }

        RegKindConverter(void* pIce, void* pKind)
        {
            IceSource = pIce;
            KindSource = pKind;
        }

        readonly void* IceSource;

        readonly void* KindSource;

        ReadOnlySpan<IceRegister> Ice
        {
            [MethodImpl(Inline)]
            get => @ref<Index<IceRegister>>(IceSource).View;
        }

        public ReadOnlySpan<RegKind> Kinds
        {
            [MethodImpl(Inline)]
            get => @ref<Index<RegKind>>(KindSource).View;
        }

        [MethodImpl(Inline), Op]
        public RegKind convert(IceRegister src)
            => skip(Kinds, (int)src);

        [MethodImpl(Inline), Op]
        public IceRegister convert(RegKind src)
            => skip(Ice, (int)src);

    }

    readonly partial struct RegConversionData
    {

    }
}