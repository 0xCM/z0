//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    public enum xed_chip_enum_t
    {
        XED_CHIP_INVALID,
        XED_CHIP_I86,
        XED_CHIP_I86FP,
        XED_CHIP_I186,
        XED_CHIP_I186FP,
        XED_CHIP_I286REAL,
        XED_CHIP_I286,
        XED_CHIP_I2186FP,
        XED_CHIP_I386REAL,
        XED_CHIP_I386,
        XED_CHIP_I386FP,
        XED_CHIP_I486REAL,
        XED_CHIP_I486,
        XED_CHIP_PENTIUMREAL,
        XED_CHIP_PENTIUM,
        XED_CHIP_QUARK,
        XED_CHIP_PENTIUMMMXREAL,
        XED_CHIP_PENTIUMMMX,
        XED_CHIP_ALLREAL,
        XED_CHIP_PENTIUMPRO,
        XED_CHIP_PENTIUM2,
        XED_CHIP_PENTIUM3,
        XED_CHIP_PENTIUM4,
        XED_CHIP_P4PRESCOTT,
        XED_CHIP_P4PRESCOTT_NOLAHF,
        XED_CHIP_P4PRESCOTT_VTX,
        XED_CHIP_CORE2,
        XED_CHIP_PENRYN,
        XED_CHIP_PENRYN_E,
        XED_CHIP_NEHALEM,
        XED_CHIP_WESTMERE,
        XED_CHIP_BONNELL,
        XED_CHIP_SALTWELL,
        XED_CHIP_SILVERMONT,
        XED_CHIP_VIA,
        XED_CHIP_AMD,
        XED_CHIP_GOLDMONT,
        XED_CHIP_GOLDMONT_PLUS,
        XED_CHIP_TREMONT,
        XED_CHIP_SANDYBRIDGE,
        XED_CHIP_IVYBRIDGE,
        XED_CHIP_HASWELL,
        XED_CHIP_BROADWELL,
        XED_CHIP_SKYLAKE,
        XED_CHIP_SKYLAKE_SERVER,
        XED_CHIP_CASCADE_LAKE,
        XED_CHIP_KNL,
        XED_CHIP_KNM,
        XED_CHIP_CANNONLAKE,
        XED_CHIP_ICELAKE,
        XED_CHIP_ICELAKE_SERVER,
        XED_CHIP_FUTURE,
        XED_CHIP_ALL,
        XED_CHIP_LAST

    }
}