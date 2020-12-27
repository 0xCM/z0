//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Retrieves a <see cref='string'/> pointer
        /// </summary>
        /// <param name="src">The source string</param>
        /// <remarks>
        /// 0000h nop dword ptr [rax+rax]                 ; NOP r/m32                        | 0F 1F /0                         | 5   | 0f 1f 44 00 00
        /// 0005h test rcx,rcx                            ; TEST r/m64, r64                  | REX.W 85 /r                      | 3   | 48 85 c9
        /// 0008h jne short 000eh                         ; JNE rel8                         | 75 cb                            | 2   | 75 04
        /// 000ah xor eax,eax                             ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
        /// 000ch jmp short 0015h                         ; JMP rel8                         | EB cb                            | 2   | eb 07
        /// 000eh lea rax,[rcx+0ch]                       ; LEA r64, m                       | REX.W 8D /r                      | 4   | 48 8d 41 0c
        /// 0012h mov edx,[rcx+8]                         ; MOV r32, r/m32                   | 8B /r                            | 3   | 8b 51 08
        /// 0015h ret                                     ; RET                              | C3                               | 1   | c3
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static unsafe char* pchar(string src)
            => gptr(first(span(src)));

        /// <summary>
        /// Retrieves a <see cref='string'/> pointer
        /// </summary>
        /// <param name="src">The source string</param>
        /// <remarks>
        /// 0000h nop dword ptr [rax+rax]                 ; NOP r/m32                        | 0F 1F /0                         | 5   | 0f 1f 44 00 00
        /// 0005h mov [rsp+8],rcx                         ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 4c 24 08
        /// 000ah lea rax,[rsp+8]                         ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 44 24 08
        /// 000fh ret                                     ; RET                              | C3                               | 1   | c3
        /// </remarks>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe char* pchar2(string src)
            => gptr(@as<string,char>(src));
    }
}