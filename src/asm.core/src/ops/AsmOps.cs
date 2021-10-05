//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static AsmOperands;
    using static core;
    using static Root;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost, Free]
    public partial class AsmOps
    {
        [MethodImpl(Inline), Op]
        public static KNOTB knotb(rK op0, rK op1)
            => new KNOTB(op0, op1);

        [MethodImpl(Inline), Op]
        public static KNOTW knotw(rK op0, rK op1)
            => new KNOTW(op0, op1);

        [MethodImpl(Inline), Op]
        public static KNOTD knotd(rK op0, rK op1)
            => new KNOTD(op0, op1);

        [MethodImpl(Inline), Op]
        public static KNOTQ knotq(rK op0, rK op1)
            => new KNOTQ(op0, op1);
    }
}