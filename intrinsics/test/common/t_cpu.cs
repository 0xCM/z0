//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    public abstract class t_cpu<T> : t_inx<T>
        where T : t_cpu<T>, new()
    {
        protected Cpu cpu;

        protected t_cpu()
        {
            cpu = Cpu.Init();
        }

        /// <summary>
        /// Returns a slot-identified XMM cpu register refererence
        /// </summary>
        /// <param name="slot">The slot index of the register, an integer betwee 0 and 15</param>
        [MethodImpl(Inline)]
        protected ref XMM xmm(int slot)                
            => ref cpu.xmm(slot);

        /// <summary>
        /// Returns a slot-identified YMM cpu register refererence
        /// </summary>
        /// <param name="slot">The slot index of the register, an integer betwee 0 and 15</param>
        [MethodImpl(Inline)]
        protected ref YMM ymm(int slot)                
            => ref cpu.ymm(slot);

        [MethodImpl(Inline)]
        protected Imm8 imm8(bit? b0 = null, bit? b1 = null, bit? b2 = null, bit? b3 = null,bit? b4 = null, bit? b5 = null, bit? b6 = null, bit? b7 = null)
            => Imm8.From(b0 ?? false, b1 ?? false, b2 ?? false, b3 ?? false, b4 ?? false, b5 ?? false, b6 ?? false, b7 ?? false);

        /// <summary>
        /// Formats a slot-identified XMM register as cells of specified type
        /// </summary>
        /// <param name="i">The slot index</param>
        /// <typeparam name="X">The cell type</typeparam>
        protected string FormatXmm<X>(int i)
            where X : unmanaged
                => cpu.XmmFormat<X>(i);

        /// <summary>
        /// Formats a slot-identified XMM register as cells of specified type
        /// </summary>
        /// <param name="i">The slot index</param>
        /// <typeparam name="X">The cell type</typeparam>
        protected string FormatYmm<X>(int i)
            where X : unmanaged
                => cpu.YmmFormat<X>(i);

        /// <summary>
        /// Block-formats an immediate
        /// </summary>
        /// <param name="i">The slot index</param>
        /// <typeparam name="X">The cell type</typeparam>
        protected string FormatImm<X>(Imm8 imm)
            where X : unmanaged
                => imm.FormatBlocked<X>();
    }
}