//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Root;

    partial struct Prototypes
    {
        [ApiHost(prototypes + pointers)]
        public unsafe readonly struct Pointers
        {
            [Op]
            public static void f_32u_p8u_p8u_p8u_void(uint count, byte* pA, byte* pB, byte* pDst)
            {
                var i=0u;
                pDst[i++] = math.and(pA[0], pB[0]);
                pDst[i++] = math.or(pA[1], pB[1]);
                pDst[i++] = math.xor(pA[2], pB[2]);
                pDst[i++] = math.mul(pA[3], pB[3]);
                pDst[i++] = math.div(pA[3], pB[3]);
                pDst[i++] = math.mod(pA[3], pB[3]);
            }

            [Op]
            public static void f_32u_p8i_p8i_p8i_void(uint count, sbyte* pA, sbyte* pB, sbyte* pDst)
            {
                var i=0u;
                pDst[i++] = math.and(pA[0], pB[0]);
                pDst[i++] = math.or(pA[1], pB[1]);
                pDst[i++] = math.xor(pA[2], pB[2]);
                pDst[i++] = math.mul(pA[3], pB[3]);
                pDst[i++] = math.div(pA[3], pB[3]);
                pDst[i++] = math.mod(pA[3], pB[3]);
            }

            [Op]
            public static void f_32u_p16u_p16u_p16u_void(uint count, ushort* pA, ushort* pB, ushort* pDst)
            {
                for(var i=0u; i<count; i++)
                    pDst[i] = math.mul(pA[i], pB[i]);
            }

            [Op]
            public static void f_32u_p16i_p16i_p16i_void(uint count, short* pA, short* pB, short* pDst)
            {
                var i=0u;
                pDst[i++] = math.and(pA[0], pB[0]);
                pDst[i++] = math.or(pA[1], pB[1]);
                pDst[i++] = math.xor(pA[2], pB[2]);
                pDst[i++] = math.mul(pA[3], pB[3]);
                pDst[i++] = math.div(pA[3], pB[3]);
                pDst[i++] = math.mod(pA[3], pB[3]);
            }

            [Op]
            public static void f_32u_p32i_p32i_p32i_void(uint count, int* pA, int* pB, int* pDst)
            {
                var i=0u;
                pDst[i++] = math.and(pA[0], pB[0]);
                pDst[i++] = math.or(pA[1], pB[1]);
                pDst[i++] = math.xor(pA[2], pB[2]);
                pDst[i++] = math.mul(pA[3], pB[3]);
                pDst[i++] = math.div(pA[3], pB[3]);
                pDst[i++] = math.mod(pA[3], pB[3]);
            }

            [Op]
            public static void f_32u_p32u_p32u_p32u_void(uint count, uint* pA, uint* pB, uint* pDst)
            {
                var i=0u;
                pDst[i++] = math.and(pA[0], pB[0]);
                pDst[i++] = math.or(pA[1], pB[1]);
                pDst[i++] = math.xor(pA[2], pB[2]);
                pDst[i++] = math.mul(pA[3], pB[3]);
                pDst[i++] = math.div(pA[3], pB[3]);
                pDst[i++] = math.mod(pA[3], pB[3]);
            }

            [Op]
            public static void f_32u_p64u_p64u_p64u_void(uint count, ulong* pA, ulong* pB, ulong* pDst)
            {
                var i=0u;
                pDst[i++] = math.and(pA[0], pB[0]);
                pDst[i++] = math.or(pA[1], pB[1]);
                pDst[i++] = math.xor(pA[2], pB[2]);
                pDst[i++] = math.mul(pA[3], pB[3]);
                pDst[i++] = math.div(pA[3], pB[3]);
                pDst[i++] = math.mod(pA[3], pB[3]);
            }

            [Op]
            public static void f_pc128u_pc128u_pc128u_void(Cell128* pA, Cell128* pB, Cell128* pDst)
            {
                // 0000h sub rsp,58h
                // 0004h vzeroupper
                var i=0u;

                // 0007h vmovupd xmm0,[rcx+10h]
                // 000ch vmovupd xmm1,[rdx+10h]
                // 0011h vpand xmm0,xmm0,xmm1
                // 0015h vmovapd [rsp+40h],xmm0
                // 001bh vmovdqu xmm0,xmmword ptr [rsp+40h]
                // 0021h vmovdqu xmmword ptr [r8],xmm0
                pDst[i++] = gcpu.vand<byte>(pA[i], pB[i]);
                // 0026h vmovupd xmm0,[rcx+20h]
                // 002bh vmovupd xmm1,[rdx+20h]
                // 0030h vpor xmm0,xmm0,xmm1
                // 0034h vmovapd [rsp+30h],xmm0
                // 003ah lea rax,[r8+10h]
                // 003eh vmovdqu xmm0,xmmword ptr [rsp+30h]
                // 0044h vmovdqu xmmword ptr [rax],xmm0
                pDst[i++] = gcpu.vor<byte>(pA[i], pB[i]);
                // 0048h vmovupd xmm0,[rcx+30h]
                // 004dh vmovupd xmm1,[rdx+30h]
                // 0052h vpxor xmm0,xmm0,xmm1
                // 0056h vmovapd [rsp+20h],xmm0
                // 005ch lea rax,[r8+20h]
                // 0060h vmovdqu xmm0,xmmword ptr [rsp+20h]
                // 0066h vmovdqu xmmword ptr [rax],xmm0
                pDst[i++] = gcpu.vxor<byte>(pA[i], pB[i]);
                // 006ah vmovupd xmm0,[rcx+40h]
                // 006fh vmovupd xmm1,[rdx+40h]
                // 0074h vpsubb xmm0,xmm0,xmm1
                // 0078h vmovapd [rsp+10h],xmm0
                // 007eh lea rax,[r8+30h]
                // 0082h vmovdqu xmm0,xmmword ptr [rsp+10h]
                // 0088h vmovdqu xmmword ptr [rax],xmm0
                pDst[i++] = gcpu.vsub<byte>(pA[i], pB[i]);
                // 008ch vmovupd xmm0,[rcx+50h]
                // 0091h vmovupd xmm1,[rdx+50h]
                // 0096h vpaddb xmm0,xmm0,xmm1
                // 009ah vmovapd [rsp],xmm0
                // 009fh add r8,40h
                // 00a3h vmovdqu xmm0,xmmword ptr [rsp]
                // 00a8h vmovdqu xmmword ptr [r8],xmm0
                pDst[i++] = gcpu.vadd<byte>(pA[i], pB[i]);
                // 00adh add rsp,58h
                // 00b1h ret
            }
        }
    }
}