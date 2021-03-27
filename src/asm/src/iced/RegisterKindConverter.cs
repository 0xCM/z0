//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

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
            this.pIce = pIce;
            this.pKind = pKind;
        }

        readonly void* pIce;

        readonly void* pKind;

        ReadOnlySpan<IceRegister> Ice
        {
            [MethodImpl(Inline)]
            get => @ref<Index<IceRegister>>(pIce).View;
        }

        ReadOnlySpan<RegKind> Kinds
        {
            [MethodImpl(Inline)]
            get => @ref<Index<RegKind>>(pKind).View;
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