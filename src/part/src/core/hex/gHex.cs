//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct gHex
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static byte value<H>(H h= default)
            where H : unmanaged, IHexType
                => (byte)h.Value;

        [MethodImpl(Inline)]
        public static HexIndex<K> index<K>(K[] src)
            where K : unmanaged, IHexNumber
                => new HexIndex<K>(src);

        [MethodImpl(Inline)]
        public static HexString<K> hexstring<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Seq))
                return generic<K>(new HexString<Hex1Seq>(Hex1Text.x00));
            else if(typeof(K) == typeof(Hex2Seq))
                return generic<K>(new HexString<Hex2Seq>(Hex2Text.x00));
            else if(typeof(K) == typeof(Hex3Seq))
                return generic<K>(new HexString<Hex3Seq>(Hex3Text.x00));
            else if(typeof(K) == typeof(Hex4Seq))
                return generic<K>(new HexString<Hex4Seq>(Hex4Text.x00));
            else
                return HexString<K>.Empty;
        }

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex1Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex1Seq>,HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex2Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex2Seq>,HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex3Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex3Seq>,HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex4Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex4Seq>, HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex1Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex1Seq>, HexStrings<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex2Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex2Seq>, HexStrings<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex3Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex3Seq>, HexStrings<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex4Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex4Seq>, HexStrings<K>>(edit(src));

        [Op, Closures(Closure)]
        public static Index<HexCodeLo> digits<T>(in T src, LowerCased @case)
            where T : struct
        {
            var count = size<T>();
            var dst = alloc<HexCodeLo>(count*2);
            digits(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void digits<T>(in T src, Span<HexCodeLo> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = Hex.code(n4, LowerCase, d);
                seek(dst, j--) = Hex.code(n4, LowerCase, Bytes.srl(d, 4));
            }
        }
    }
}