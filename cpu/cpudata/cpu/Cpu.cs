//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static Registers;

    public class Cpu
    {
        YmmBank Ymm;
        
        GpRegBank Gpr;

        CS CS = default;

        DS DS = default;

        ES ES = default;

        FS FS = default;

        GS GS = default;

        SS SS = default;


        [MethodImpl(Inline)]
        public static Cpu Init()
            => new Cpu();

        public void Reset()
        {
            rax = 0ul; 
            rcx = 0ul;           
            rbx = 0ul;
            rdx = 0ul;
            rsi = 0ul;
            rdi = 0ul;
            rsp = 0ul;
            rbp = 0ul;
            r8 = 0ul;
            r9 = 0ul;
            r10 = 0ul;
            r11 = 0ul;
            r12 = 0ul;
            r13 = 0ul;
            r14 = 0ul;
            r15 = 0ul;
    
        }


        //~ RAX
        //~ ----------------------------
        public ref AL al
        {
            [MethodImpl(Inline)]
            get => ref Gpr.al;
        }

        public ref AX ax
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ax;
        }

        public ref EAX eax
        {
            [MethodImpl(Inline)]
            get => ref Gpr.eax;
        }

        public ref RAX rax
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rax;
        }

        //~ RCX
        //~ ----------------------------

        public ref CL cl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.cl;
        }

        public ref CX cx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.cx;
        }

        public ref ECX ecx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ecx;
        }


        public ref RCX rcx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rcx;
        }

        //~ RBX
        //~ ----------------------------
        
        public ref BL bl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bl;
        }

        public ref BX bx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bx;
        }

        public ref EBX ebx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ebx;
        }

        public ref RBX rbx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rbx;
        }

        //~ RDX
        //~ ----------------------------

        public ref DL dl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.dl;
        }

        public ref DX dx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.dx;
        }

        public ref EDX edx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.edx;
        }

        public ref RDX rdx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rdx;
        }

        //~ RSI
        //~ ----------------------------

        public ref SIL sil
        {
            [MethodImpl(Inline)]
            get => ref Gpr.sil;
        }

        public ref SI si
        {
            [MethodImpl(Inline)]
            get => ref Gpr.si;
        }

        public ref ESI esi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.esi;
        }

        public ref RSI rsi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rsi;
        }

        //~ RBP
        //~ ----------------------------

        public ref BPL bpl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bpl;
        }

        public ref BP bp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bp;
        }

        public ref EBP ebp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ebp;
        }

        public ref RBP rbp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rbp;
        }

        //~ RDI
        //~ ----------------------------

        public ref DIL dil
        {
            [MethodImpl(Inline)]
            get => ref Gpr.dil;
        }

        public ref DI di
        {
            [MethodImpl(Inline)]
            get => ref Gpr.di;
        }

        public ref EDI edi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.edi;
        }

        public ref RDI rdi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rdi;
        }

        //~ RSP
        //~ ----------------------------

        public ref SPL spl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.spl;
        }

        public ref SP sp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.sp;
        }

        public ref ESP esp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.esp;
        }

        public ref RSP rsp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rsp;
        }

        //~ R8
        //~ ----------------------------

        public ref R8B r8b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8b;
        }

        public ref R8W r8w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8w;
        }

        public ref R8D r8d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8d;
        }

        public ref R8 r8
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8;
        }

        //~ R9
        //~ ----------------------------

        public ref R9B r9b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9b;
        }

        public ref R9W r9w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9w;
        }

        public ref R9D r9d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9d;
        }

        public ref R9 r9
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9;
        }

        //~ R10
        //~ ----------------------------

        public ref R10B r10b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10b;
        }

        public ref R10W r10w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10w;
        }

        public ref R10D r10d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10d;
        }

        public ref R10 r10
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10;
        }

        //~ R11
        //~ ----------------------------

        public ref R11B r11b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11b;
        }

        public ref R11W r11w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11w;
        }

        public ref R11D r11d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11d;
        }

        public ref R11 r11
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11;
        }


        //~ R12
        //~ ----------------------------

        public ref R12B r12b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12b;
        }

        public ref R12W r12w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12w;
        }

        public ref R12D r12d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12d;
        }

        public ref R12 r12
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12;
        }

        //~ R13
        //~ ----------------------------

        public ref R13B r13b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13b;
        }

        public ref R13W r13w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13w;
        }

        public ref R13D r13d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13d;
        }

        public ref R13 r13
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13;
        }

        //~ R14
        //~ ----------------------------

        public ref R14B r14b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14b;
        }

        public ref R14W r14w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14w;
        }

        public ref R14D r14d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14d;
        }

        public ref R14 r14
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14;
        }

        //~ R15
        //~ ----------------------------

        public ref R15B r15b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15b;
        }

        public ref R15W r15w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15w;
        }

        public ref R15D r15d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15d;
        }

        public ref R15 r15
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15;
        }


        //~ Segment Registers
        //~ ----------------------------

        public ref CS cs
        {
            [MethodImpl(Inline)]
            get => ref CS;
        }

        public ref DS ds
        {
            [MethodImpl(Inline)]
            get => ref DS;
        }

        public ref ES es
        {
            [MethodImpl(Inline)]
            get => ref ES;
        }

        public ref FS fs
        {
            [MethodImpl(Inline)]
            get => ref FS;
        }

        public ref GS gs
        {
            [MethodImpl(Inline)]
            get => ref GS;
        }

        public ref SS ss
        {
            [MethodImpl(Inline)]
            get => ref SS;
        }

    
        /// <summary>
        /// Selects a slot-identified xmm register
        /// </summary>
        /// <param name="slot">The slot index, an integer between 0 and 15</param>
        [MethodImpl(Inline)]
        public ref XMM xmm(int slot)
            => ref Ymm.XmmSlot(slot);

        /// <summary>
        /// Selects the memory from a slot-identified xmm register
        /// </summary>
        /// <param name="slot">The slot index, an integer between 0 and 15</param>
        [MethodImpl(Inline)]
        public ref T xmem<T>(int slot)
            where T : unmanaged
                => ref Ymm.XmmSlot(slot).First<T>();

        /// <summary>
        /// Selects the memory from a slot-identified ymm register
        /// </summary>
        /// <param name="slot">The slot index, an integer between 0 and 15</param>
        [MethodImpl(Inline)]
        public ref T ymem<T>(int slot)
            where T : unmanaged
                => ref Ymm.YmmSlot(slot).First<T>();

        /// <summary>
        /// Selects a slot-identified ymm register
        /// </summary>
        /// <param name="slot">The slot index, an integer between 0 and 15</param>
        [MethodImpl(Inline)]
        public ref YMM ymm(int slot)
            => ref Ymm.YmmSlot(slot);

        /// <summary>
        /// Selects the xmm register at slot 0
        /// </summary>
        public ref XMM xmm0
        {
            [MethodImpl(Inline)]
            get => ref xmm(0);
        }

        /// <summary>
        /// Selects the xmm register at slot 1
        /// </summary>
        public ref XMM xmm1
        {
            [MethodImpl(Inline)]
            get => ref xmm(1);
        }

        /// <summary>
        /// Selects the xmm register at slot 2
        /// </summary>
        public ref XMM xmm2
        {
            [MethodImpl(Inline)]
            get => ref xmm(2);
        }

        /// <summary>
        /// Selects the xmm register at slot 3
        /// </summary>
        public ref XMM xmm3
        {
            [MethodImpl(Inline)]
            get => ref xmm(3);
        }

        /// <summary>
        /// Selects the xmm register at slot 4
        /// </summary>
        public ref XMM xmm4
        {
            [MethodImpl(Inline)]
            get => ref xmm(4);
        }

        /// <summary>
        /// Selects the xmm register at slot 5
        /// </summary>
        public ref XMM xmm5
        {
            [MethodImpl(Inline)]
            get => ref xmm(5);
        }

        /// <summary>
        /// Selects the xmm register at slot 6
        /// </summary>
        public ref XMM xmm6
        {
            [MethodImpl(Inline)]
            get => ref xmm(6);
        }

        /// <summary>
        /// Selects the xmm register at slot 7
        /// </summary>
        public ref XMM xmm7
        {
            [MethodImpl(Inline)]
            get => ref xmm(7);
        }

        /// <summary>
        /// Selects the xmm register at slot 8
        /// </summary>
        public ref XMM xmm8
        {
            [MethodImpl(Inline)]
            get => ref xmm(8);
        }

        /// <summary>
        /// Selects the xmm register at slot 9
        /// </summary>
        public ref XMM xmm9
        {
            [MethodImpl(Inline)]
            get => ref xmm(9);
        }

        /// <summary>
        /// Selects the xmm register at slot 10
        /// </summary>
        public ref XMM xmm10
        {
            [MethodImpl(Inline)]
            get => ref xmm(10);
        }

        /// <summary>
        /// Selects the xmm register at slot 11
        /// </summary>
        public ref XMM xmm11
        {
            [MethodImpl(Inline)]
            get => ref xmm(11);
        }

        /// <summary>
        /// Selects the xmm register at slot 12
        /// </summary>
        public ref XMM xmm12
        {
            [MethodImpl(Inline)]
            get => ref xmm(12);
        }

        /// <summary>
        /// Selects the xmm register at slot 13
        /// </summary>
        public ref XMM xmm13
        {
            [MethodImpl(Inline)]
            get => ref xmm(13);
        }

        /// <summary>
        /// Selects the xmm register at slot 14
        /// </summary>
        public ref XMM xmm14
        {
            [MethodImpl(Inline)]
            get => ref xmm(14);
        }

        /// <summary>
        /// Selects the xmm register at slot 15
        /// </summary>
        public ref XMM xmm15
        {
            [MethodImpl(Inline)]
            get => ref xmm(15);
        }

        /// <summary>
        /// Selects the ymm register at slot 0
        /// </summary>
        public ref YMM ymm0
        {
            [MethodImpl(Inline)]
            get => ref ymm(0);
        }

        /// <summary>
        /// Selects the ymm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        public ref YMM ymm1
        {
            [MethodImpl(Inline)]
            get => ref ymm(1);
        }

        /// <summary>
        /// Selects the ymm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        public ref YMM ymm2
        {
            [MethodImpl(Inline)]
            get => ref ymm(2);
        }

        /// <summary>
        /// Selects the ymm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        public ref YMM ymm3
        {
            [MethodImpl(Inline)]
            get => ref ymm(3);
        }

        /// <summary>
        /// Selects the ymm register at slot 4
        /// </summary>
        public ref YMM ymm4
        {
            [MethodImpl(Inline)]
            get => ref ymm(4);
        }

        /// <summary>
        /// Selects the ymm register at slot 5
        /// </summary>
        public ref YMM ymm5
        {
            [MethodImpl(Inline)]
            get => ref ymm(5);
        }

        /// <summary>
        /// Selects the ymm register at slot 6
        /// </summary>
        public ref YMM ymm6
        {
            [MethodImpl(Inline)]
            get => ref ymm(6);
        }

        /// <summary>
        /// Selects the ymm register at slot 7
        /// </summary>
        public ref YMM ymm7
        {
            [MethodImpl(Inline)]
            get => ref ymm(7);
        }

        /// <summary>
        /// Selects the ymm register at slot 8
        /// </summary>
        public ref YMM ymm8
        {
            [MethodImpl(Inline)]
            get => ref ymm(8);
        }

        /// <summary>
        /// Selects the ymm register at slot 9
        /// </summary>
        public ref YMM ymm9
        {
            [MethodImpl(Inline)]
            get => ref ymm(9);
        }

        /// <summary>
        /// Selects the ymm register at slot 10
        /// </summary>
        public ref YMM ymm10
        {
            [MethodImpl(Inline)]
            get => ref ymm(10);
        }

        /// <summary>
        /// Selects the ymm register at slot 11
        /// </summary>
        public ref YMM ymm11
        {
            [MethodImpl(Inline)]
            get => ref ymm(11);
        }

        /// <summary>
        /// Selects the ymm register at slot 12
        /// </summary>
        public ref YMM ymm12
        {
            [MethodImpl(Inline)]
            get => ref ymm(12);
        }

        /// <summary>
        /// Selects the ymm register at slot 13
        /// </summary>
        public ref YMM ymm13
        {
            [MethodImpl(Inline)]
            get => ref ymm(13);
        }

        /// <summary>
        /// Selects the ymm register at slot 14
        /// </summary>
        public ref YMM ymm14
        {
            [MethodImpl(Inline)]
            get => ref ymm(14);
        }

        /// <summary>
        /// Selects the ymm register at slot 15
        /// </summary>
        public ref YMM ymm15
        {
            [MethodImpl(Inline)]
            get => ref ymm(15);
        }

        /// <summary>
        /// Formats a slot-identified XMM register as cells of specified type
        /// </summary>
        /// <param name="slot">The slot index</param>
        /// <typeparam name="T">The cell type</typeparam>
        public string XmmFormat<T>(int slot)
            where T : unmanaged
        {
            var label = $"xmm{slot}".PadRight(6);
            var content = xmm(slot);
            var format = content.Format<T>();
            return $"{label}{format}";
        }

        /// <summary>
        /// Formats a slot-identified YMM register as cells of specified type
        /// </summary>
        /// <param name="slot">The slot index</param>
        /// <typeparam name="T">The cell type</typeparam>
        public string YmmFormat<T>(int slot)
            where T : unmanaged
        {
            var label = $"ymm{slot}".PadRight(6);
            var content = ymm(slot);
            var format = content.Format<T>();
            return $"{label}{format}";
        }


        /// <summary>
        /// Performs integer multiplication between source and target registers
        /// and places the result in the target register
        /// </summary>
        /// <param name="dst">Target register identifer</param>
        /// <param name="src">Source register identifier</param>
        public int imul(GpRegId dst, GpRegId src)
        {            
            var srcLoc = src.Address();
            var dstLoc = dst.Address();
            
            ref var srcRef = ref Gpr.Ref(srcLoc);
            ref var dstRef = ref Gpr.Ref(dstLoc);
            srcRef.CopyTo(ref dstRef, srcLoc.Size);

            return 0;            
        }

        /// <summary>
        /// Copies the content of one register to another
        /// </summary>
        /// <param name="dst">Target register identifer</param>
        /// <param name="src">Source register identifier</param>
        public int mov(GpRegId dst, GpRegId src)
        {            
            var srcLoc = src.Address();
            var dstLoc = dst.Address();

            if(srcLoc.Size > dstLoc.Size)
                return -1;
            
            ref var srcRef = ref Gpr.Ref(srcLoc);
            ref var dstRef = ref Gpr.Ref(dstLoc);
            srcRef.CopyTo(ref dstRef, srcLoc.Size);

            return 0;            
        }

        /// <summary>
        /// Copies the content of an identified register to a target reference
        /// </summary>
        /// <param name="dst">The target reference</param>
        /// <param name="src">Source register identifier</param>
        /// <typeparam name="T">Target reference type</typeparam>
        public int mov<T>(ref T dst, GpRegId src)
            where T : unmanaged
        {
            var srcLoc = src.Address();
            var dstSize = Unsafe.SizeOf<T>();
            if(srcLoc.Size > dstSize)
                return -1;

            ref var srcRef = ref Gpr.Ref(srcLoc);
            ref var dstRef = ref Unsafe.As<T, byte>(ref dst);
            srcRef.CopyTo(ref dstRef, srcLoc.Size);
            
            return 0;
        }

        /// <summary>
        /// Copies a source value to an identified register
        /// </summary>
        /// <param name="dst">Target register identifer</param>
        /// <param name="src">Source value</param>
        /// <typeparam name="T">Source value type</typeparam>
        public int mov<T>(GpRegId dst, T src)
            where T : unmanaged
        {
            var dstLoc = dst.Address();
            var srcSize = Unsafe.SizeOf<T>();
            if(srcSize > dstLoc.Size)
                return -1;

            ref var srcRef = ref src.Head();
            ref var dstRef = ref Gpr.Ref(dstLoc);
            srcRef.CopyTo(ref dstRef, dstLoc.Size);
            
            return 0;
        }

    }
}