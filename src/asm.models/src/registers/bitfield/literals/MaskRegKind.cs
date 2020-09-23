//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterClass;
    using static RegisterWidth;

    using RK = RegisterKind;

    /// <summary>
    /// Defines classifiers for <see cref='Mask'/> registers of width <see cref='W64'/>
    /// </summary>
    public enum MaskRegKind : uint
    {
        K0 = RK.K0,

        K1 = RK.K1,

        K2 = RK.K2,

        K3 = RK.K3,

        K4 = RK.K4,

        K5 = RK.K5,

        K6 = RK.K6,

        K7 = RK.K7,
    }
}