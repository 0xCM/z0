//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsciTestCase02 : ITestCase<AsciTestCase02>
    {
        [MethodImpl(Inline)]
        public static AsciTestCase02 Create(AsciCharCode c0 = AsciCharCode.Bang)
            => new AsciTestCase02((sbyte)c0);

        [MethodImpl(Inline)]
        internal AsciTestCase02(sbyte c0)
        {
            C0 = (AsciCharCode)c0;
            A2 = Asci.init(n2, Asci.codes(c0,2));
            A4 = Asci.init(n4, Asci.codes(c0,4));
            A8 = Asci.init(n8, Asci.codes(c0,8));
            A16 = Asci.init(n16, Asci.codes(c0,16));
            A32 = Asci.init(n32, Asci.codes(c0,32));
            A64 = Asci.init(n64, Asci.codes(c0,64));
        }

        public readonly AsciCharCode C0;

        public readonly asci2 A2;

        public readonly asci4 A4;

        public readonly asci8 A8;

        public readonly asci16 A16;

        public readonly asci32 A32;

        public readonly asci64 A64;
    }
}