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

    [ApiHost]
    public readonly partial struct ClrStorage
    {
        [Op]
        public static unsafe string readString(in byte* pSrcPos, uint bytes, ref byte* pDstPos)
        {
            var pb = pSrcPos;
            var buffer = new char[bytes];
            var length = 0;
            fixed (char* pC16Fixed = buffer)
            {
                char* pC16 = pC16Fixed;
                char* pC16End = pC16Fixed + bytes;
                while (pC16 < pC16End)
                {
                    var b = *pb++;
                    if (b == 0)
                        break;

                    *pC16++ = (char)b;
                    length++;
                }
            }
            pDstPos += bytes;

            return new string(buffer, 0, length);
        }

        [MethodImpl(Inline), Op]
        public unsafe static void read(in byte src, uint chars, ref char dst)
        {
            for(var i=0; i<chars; i++)
                seek(dst, i) = @as<char>(skip(src,i*2));
        }

        [MethodImpl(Inline), Op]
        public unsafe static ref string copy(in byte src, uint chars, ref char buffer, out string dst)
        {
            read(src, chars, ref buffer);
            dst = new string(pointer(ref buffer), 0, (int)chars);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static string read(in byte src, uint length, out string dst)
        {
            Span<char> buffer = stackalloc char[(int)length];
            return copy(src, length, ref first(buffer), out dst);
        }
    }
}