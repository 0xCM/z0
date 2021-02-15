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

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode encoding(ulong src)
            => src;

        [Op]
        public static AsmHexCode encoding(ReadOnlySpan<byte> src)
        {
            var count = root.min(8,src.Length);
            if(count == 0)
                return AsmHexCode.Empty;

            if(count >= 8)
                return encoding(first64u(src));

            var dst = z64;
            switch(count)
            {
                case 7:
                    dst = first32u(src);
                    dst |= (ulong)skip(src, 4) << 32;
                    dst |= (ulong)skip(src, 5) << 40;
                    dst |= (ulong)skip(src, 6) << 48;
                    break;
                case 6:
                    dst = first32u(src);
                    dst |= (ulong)skip(src, 4) << 32;
                    dst |= (ulong)skip(src, 5) << 40;
                    break;
                case 5:
                    dst = first32u(src);
                    dst |= (ulong)skip(src, 4) << 32;
                    break;
                case 4:
                    dst = first32u(src);
                    break;
                case 3:
                    dst = first16u(src);
                    dst |= (ulong)skip(src, 2) << 16;
                    break;
                case 2:
                    dst = first16u(src);
                    break;
                default:
                    dst = first(src);
                    break;
            }
            return encoding(dst);
        }


        [Op]
        public static bool encoding(string src, out AsmHexCode dst)
        {
            var parser = HexByteParser.Service;
            if(parser.Parse(src, out var data))
            {
                dst = encoding(@readonly(data));
                return true;
            }
            else
            {
                dst = AsmHexCode.Empty;
                return false;
            }
        }

        [Op]
        public static AsmHexCode encoding(string src)
        {
            var dst = AsmHexCode.Empty;
            encoding(src, out dst);
            return dst;
        }
    }
}