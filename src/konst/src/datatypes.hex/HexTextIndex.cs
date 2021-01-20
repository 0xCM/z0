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

    using H = Hex3;
    using K = Hex3Seq;
    using T = Hex3Text;
    using N = N3;

    [ApiHost]
    public readonly struct HexTextIndex
    {
        /// <summary>
        /// Returns the address of the first character in the source string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        static unsafe MemoryAddress address(string src)
            => memory.address(memory.pchar(src));

        [MethodImpl(Inline), Op]
        public static ref StringTable<ushort> strings(ref StringTable<ushort> dst)
        {
            var i=0u;
            dst.Assign(i++, (ushort)(address(T.x00) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x01) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x02) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x03) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x04) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x05) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x06) - dst.BaseAddress), 3);
            dst.Assign(i++, (ushort)(address(T.x07) - dst.BaseAddress), 3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static HexStrings<K> strings(N n, StringRef[] dst)
        {
            var target = span(dst);
            byte i = 0;
            seek(target,i++) = z.@ref(T.x00);
            seek(target,i++) = z.@ref(T.x01);
            seek(target,i++) = z.@ref(T.x02);
            seek(target,i++) = z.@ref(T.x03);
            seek(target,i++) = z.@ref(T.x04);
            seek(target,i++) = z.@ref(T.x05);
            seek(target,i++) = z.@ref(T.x06);
            seek(target,i++) = z.@ref(T.x07);
            return new HexStrings<K>(dst);
        }

        [MethodImpl(Inline)]
        public static HexIndex<K> index<K>(K[] src)
            where K : unmanaged, IHexNumber
                => new HexIndex<K>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<H> init(N n, byte[] src)
            => index<H>(@as<byte[],H[]>(src));

        [MethodImpl(Inline)]
        public static HexStrings<K> init<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Seq))
                return Hex.generic<K>(init(n1));
            else if(typeof(K) == typeof(Hex2Seq))
                return Hex.generic<K>(init(n2));
            else if(typeof(K) == typeof(Hex3Seq))
                return Hex.generic<K>(init(n3));
            else if(typeof(K) == typeof(Hex4Seq))
                return Hex.generic<K>(init(n4));
            else
                return HexStrings<K>.Empty;
        }

        [MethodImpl(Inline), Op]
        public static HexStrings<Hex1Seq> init(N1 n)
            => new HexStrings<Hex1Seq>(sys.array(z.@ref(Hex1Text.x00), z.@ref(Hex1Text.x01)));

        [MethodImpl(Inline), Op]
        public static HexStrings<Hex2Seq> init(N2 n)
            => new HexStrings<Hex2Seq>(sys.array(
                z.@ref(Hex2Text.x00), z.@ref(Hex2Text.x01),
                z.@ref(Hex2Text.x02), z.@ref(Hex2Text.x03)
                ));

        [Op]
        public static HexStrings<Hex3Seq> init(N3 n)
            => new HexStrings<Hex3Seq>(sys.array(
                    z.@ref(Hex3Text.x00), z.@ref(Hex3Text.x01), z.@ref(Hex3Text.x02), z.@ref(Hex3Text.x03),
                    z.@ref(Hex3Text.x04), z.@ref(Hex3Text.x05), z.@ref(Hex3Text.x06), z.@ref(Hex3Text.x07)
                        ));

        [Op]
        public static HexStrings<Hex4Seq> init(N4 n)
            => new HexStrings<Hex4Seq>(sys.array(
                    z.@ref(Hex4Text.x00), z.@ref(Hex4Text.x01), z.@ref(Hex4Text.x02), z.@ref(Hex4Text.x03),
                    z.@ref(Hex4Text.x04), z.@ref(Hex4Text.x05), z.@ref(Hex4Text.x06), z.@ref(Hex4Text.x07),
                    z.@ref(Hex4Text.x08), z.@ref(Hex4Text.x09), z.@ref(Hex4Text.x0A), z.@ref(Hex4Text.x0B),
                    z.@ref(Hex4Text.x0C), z.@ref(Hex4Text.x0D), z.@ref(Hex4Text.x0E), z.@ref(Hex4Text.x0F)
                    ));
    }
}