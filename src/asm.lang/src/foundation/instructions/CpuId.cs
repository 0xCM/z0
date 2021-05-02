//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;
    using static AsmRegs;

    [StructLayout(LayoutKind.Sequential)]
    public struct CpuId : ITextual
    {
        public eax Fx;

        public ecx SubFx;

        public eax Eax;

        public ebx Ebx;

        public ecx Ecx;

        public edx Edx;

        public void Clear()
            => clear(ref this);

        [MethodImpl(Inline)]
        public CpuId WithRequest(eax fx, ecx subfx)
        {
            Fx = fx;
            SubFx = subfx;
            return this;
        }

        [MethodImpl(Inline)]
        public CpuId WithResponse(in Cell128 src)
            => response(src, ref this);

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static ref CpuId clear(ref CpuId target)
        {
            memory.@as<CpuId,ByteBlock24>(target) = ByteBlocks.block(n24);
            return ref target;
        }

        [MethodImpl(Inline)]
        public static CpuId request(eax fx, ecx subfx)
        {
            var cpuid = new CpuId();
            cpuid.Fx = fx;
            cpuid.SubFx = subfx;
            return cpuid;
        }

        [MethodImpl(Inline)]
        public static ref CpuId response(in Cell128 src, ref CpuId dst)
        {
            ref var target = ref seek64(@byte(dst),1);
            @as<Cell128>(target) = src;
            return ref dst;
        }
    }
}