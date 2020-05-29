//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Asm.Data.OpKind;
    using static Seed;
    
    using Z0.Asm.Data;

    public class AsmRecordFormatter
    {
        [MethodImpl(Inline)]
        public static string Render(bool src)
            => src ? CharText.D1 : CharText.D0;
        
        [MethodImpl(Inline)]
        public static string RenderHex(string src)
            => src.RemoveBlanks().BlockPartition(2,Chars.Space);

        [MethodImpl(Inline)]
        public static string RenderScale(int src)
            => src != 0 ? src.ToString() : string.Empty;
        
        [MethodImpl(Inline)]
        public static string RenderMemDxSize(int src)
            => src != 0 ? src.ToString() : string.Empty;
        
        [MethodImpl(Inline)]
        public static string RenderHex16(ushort src)
            => src == 0 ? string.Empty : src.FormatHex(true,false);

        [MethodImpl(Inline)]
        public static string RenderHex32(uint src)
            => src == 0 ? string.Empty : src.FormatHex(false,true, prespec:false);

        [MethodImpl(Inline)]
        public static string RenderHex64(ulong src)
            => src == 0 ? string.Empty : src.FormatHex(false,false);

        [MethodImpl(Inline)]
        public static string Render(Register src)
            => src != 0 ? src.ToString() : string.Empty;

        [MethodImpl(Inline)]
        public static string Render(MemorySize src)
            => src != 0 ? src.ToString() : string.Empty;


        public static SegIndicator SI(OpKind src)
            => src switch {
                MemorySegDI => SegIndicator.di,
                MemorySegEDI => SegIndicator.edi,
                MemorySegESI => SegIndicator.esi,
                MemorySegRDI => SegIndicator.rdi,
                MemorySegRSI => SegIndicator.rsi,
                MemorySegSI => SegIndicator.si,
                MemoryESDI => SegIndicator.esdi,
                MemoryESEDI => SegIndicator.esedi,
                MemoryESRDI => SegIndicator.esrdi,
            _ => SegIndicator.Empty
            };


        public static string Render(OpKind src)
        {
            var si = SI(src);
            if(si.IsNonEmpty)
                return si.Format();

            var result = src switch{
                OpKind.Register => "reg",
                NearBranch16 => "branch16",
                NearBranch32 => "branch32",
                NearBranch64 => "branch64",
                FarBranch16 => "farbranch16",
                FarBranch32 => "farbranch32",
                Immediate8 => "imm8",
                Immediate8_2nd => "imm8x2",
                Immediate16 => "imm16",
                Immediate32 => "imm32",
                Immediate64 => "imm64",
                Immediate8to16 => "imm16i",
                Immediate8to32 => "imm32i",
                Immediate8to64 => "imm64i",
                Immediate32to64 => "imm32x64i",
                Memory64 => "mem64",
                Memory => "mem",
                    _ => src.ToString()
            };

            return result;
        }
    }
}