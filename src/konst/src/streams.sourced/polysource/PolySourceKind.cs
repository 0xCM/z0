//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x32;

    /// <summary>
    /// Defines classifiers for intrinsic polysource input sources
    /// </summary>
    public enum PolySourceKind : uint
    {
        None,

        U1 = P2ᐞ01,

        U2 = P2ᐞ02,

        U3 = P2ᐞ03,

        U4 = P2ᐞ04,

        U5 = P2ᐞ05,

        U6 = P2ᐞ06,

        U7 = P2ᐞ07,

        U8 = P2ᐞ08,

        I8 = P2ᐞ09,

        U16 = P2ᐞ10,

        I16 = P2ᐞ11,

        U32 = P2ᐞ12,

        I32 = P2ᐞ13,

        U64 = P2ᐞ14,

        I64 = P2ᐞ14,

        F32 = P2ᐞ15,

        F64 = P2ᐞ16,

        F128 = P2ᐞ17,

        C8 = P2ᐞ18,

        C16 = P2ᐞ19,

        DT = P2ᐞ20,
    }
}