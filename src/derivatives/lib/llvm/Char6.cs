//===- BitCodes.h - Enum values for the bitstream format --------*- C++ -*-===//
// Part of the LLVM Project, under the Apache License v2.0 with LLVM Exceptions.
// See https://llvm.org/LICENSE.txt for license information.
// SPDX-License-Identifier: Apache-2.0 WITH LLVM-exception
//===----------------------------------------------------------------------===//
namespace Z0.Derivatives.LLVM
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Bitcode
    {
        [ApiHost]
        public readonly struct Char6
        {
            [MethodImpl(Inline), Op]
            public static bool test(char c)
            {
                if (c >= 'a' && c <= 'z') return true;
                if (c >= 'A' && c <= 'Z') return true;
                if (c >= '0' && c <= '9') return true;
                if (c == '.' || c == '_') return true;
                return false;
            }

            [MethodImpl(Inline), Op]
            public static bool encode(char src, out byte dst)
            {
                dst = byte.MaxValue;
                if (src >= 'a' && src <= 'z')
                    dst = (byte)(src -'a');
                else if (src >= 'A' && src <= 'Z')
                    dst = (byte)(src-'A'+26);
                else if (src >= '0' && src <= '9')
                    dst = (byte)(src-'0'+26+26);
                else if (src == '.')
                    dst = 62;
                else if (src == '_')
                    dst = 63;
                return dst != byte.MaxValue;
            }

            // [MethodImpl(Inline), Op]
            // public static bool decode(byte src, out char dst)
            // {
            //     const string Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._";

            //     if((src & ~63) == 0)
            //         dst = skip(span(Chars), src);
            //     else
            //         dst = '\0';

            //     return dst != '\0';
            // }
        }
    }
}