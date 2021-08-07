//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    using K = AsmSigTokenKind;

    partial class AsmSigs
    {
        [Op]
        public static Span<AsmSigToken> unpack(GpRmToken src)
        {
            var storage = 0u;
            var count = 0;
            var buffer = recover<AsmSigToken>(bytes(storage));
            switch(src)
            {
                case GpRmToken.r:
                    seek(buffer,0) = token(K.GpReg, GpRegToken.reg);
                break;
                case GpRmToken.rm8:
                    seek(buffer,0) = token(K.GpReg, GpRegToken.r8);
                    seek(buffer,1) = token(K.Mem, MemToken.m8);
                break;
                case GpRmToken.rm16:
                    seek(buffer,0) = token(K.GpReg, GpRegToken.r16);
                    seek(buffer,1) = token(K.Mem, MemToken.m16);
                break;
                case GpRmToken.rm32:
                    seek(buffer,0) = token(K.GpReg, GpRegToken.r32);
                    seek(buffer,1) = token(K.Mem, MemToken.m32);
                break;
                case GpRmToken.rm64:
                    seek(buffer,0) = token(K.GpReg, GpRegToken.r64);
                    seek(buffer,1) = token(K.Mem, MemToken.m64);
                break;
            }
            return slice(buffer,0,count);
        }
    }
}