//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsciTestCase02 : ITestCase<AsciTestCase02>
    {
        public static AsciTestCase02 Create(AsciCharCode c0 = AsciCharCode.Bang)
            => new AsciTestCase02((sbyte)c0);

        AsciTestCase02(sbyte c0)
        {
            C0 = (AsciCharCode)c0;
            A2 = asci2.From(AsciCodes.codes(c0,1));
            A4 = asci4.From(AsciCodes.codes(c0,3));
            A8 = asci8.From(AsciCodes.codes(c0,7));
            A16 = default;
            //A16 = asci16.From(AsciCodes.codes(c0,15));
            A32 = asci32.From(AsciCodes.codes(c0,31));
            // A64 = asci64.From(AsciCodes.codes(c0,63));
        }

        public readonly AsciCharCode C0;

        public readonly asci2 A2;

        public readonly asci4 A4;

        public readonly asci8 A8;

        public readonly asci16 A16;

        public readonly asci32 A32;

        // public readonly asci64 A64;
    }
}