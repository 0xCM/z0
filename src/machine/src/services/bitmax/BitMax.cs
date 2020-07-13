//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Konst;
    using static Hex8Kind;
    using static z;

    using A = AsciChar;

    [ApiHost]
    public partial struct BitMax
    {
        [MethodImpl(Inline), Op]
        public static BitMax init(in Vector512<byte> src)
            => new BitMax(src);

        Vector512<byte> Seg0;

        Vector512<byte> Seg1;

        Vector512<byte> Seg2;

        Vector512<byte> Seg3;

        
        [MethodImpl(Inline)]
        BitMax(in Vector512<byte> src)
        {
            Seg0 = (gvec.vand(src.Lo, src.Hi), gvec.vxor(src.Lo, src.Hi));
            Seg1 = (gvec.vxnor(src.Lo, src.Hi), gvec.vor(src.Lo, src.Hi));
            Seg2 = (gvec.vsub(src.Lo, src.Hi), gvec.vadd(src.Lo, src.Hi));
            Seg3 = gvec.vcimpl(Seg0, Seg1);
        }

        [Op]
        public Vector256<byte> Run(AsciChar code)
        {
            var c0 = AsciChar.a;
            var c1 = AsciChar.b;
            var c2 = AsciChar.c;
            var c3 = AsciChar.d;
            var c4 = AsciChar.g;
            var c5 = AsciChar.e;

            switch(code)
            {
                case A.A:
                    c0 = c1;
                    c1 = c3 | c4 ^ c5;
                break;
                case A.B:
                    c0 = c2;
                break;
                case A.C:
                    c0 = c3;
                    c2 = c3 | c4 ^ c5;
                break;
                case A.D:
                    c0 = c5;
                    c1 = c2 & c3;
                break;
                case A.E:
                    c1 = c4 | c1;
                break;
            }

            for(var i=x00; i<xfe; i++)
            {
                switch(i)
                {
                    case x00:
                        goto A;
                    case x01:
                        goto B;
                    case x02:
                        goto A;
                    case x03:
                        goto B;
                    
                }

                
                for(var j=x00; j<xfe; j++)
                {

                    Seg0 = (gvec.vbroadcast(w256,(byte)i, (byte)j), gvec.vbroadcast(w256,(byte)i, (byte)j));
                    Seg2 = (gvec.vbroadcast(w256,(byte)i, (byte)j), gvec.vbroadcast(w256,(byte)i, (byte)j));

                    switch(j)
                    {
                        case x08:
                            goto A;
                        case x09:
                            goto B;
                        case x0a:
                            goto A;
                        case x0b:
                            goto B;
                        
                    }

                    for(var k=x00; k<xfe; k++)
                    {
                        switch(k)
                        {
                            case x22:
                                goto A;
                            case x29:
                                goto B;
                            case x3a:
                                goto C;
                        }

                    }
                }
            }

            A:
            Seg0 = gvec.vand(Seg2, Seg3);
            Seg1 = gvec.vand(Seg0, Seg2);
            Seg3 = gvec.vnonimpl(Seg1, Seg3);

            B:
            Seg0 = gvec.vnand(Seg1, Seg1);
            Seg1 = gvec.vor(Seg0, Seg2);
            Seg3 = gvec.vcimpl(Seg1, Seg3);

            C:
            Seg0 = (gvec.vsub(Seg2.Lo, Seg1.Hi), gvec.vsub(Seg2.Hi, Seg1.Lo));
            Seg1 = gvec.vor(Seg0, Seg2);
            Seg3 = gvec.vcimpl(Seg1, Seg3);

            return Seg0.Lo;
        }

    }
}