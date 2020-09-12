//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Collects sequences instructions from part-defined api hosts
    /// </summary>
    public readonly struct PartAsmInstructions
    {
        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part {get;}

        /// <summary>
        /// The decoded instructions
        /// </summary>
        readonly TableSpan<HostAsmFx> _Hosts;

        [MethodImpl(Inline)]
        public PartAsmInstructions(PartId part, HostAsmFx[] hosts)
        {
            Part = part;
            _Hosts = hosts;
        }

        public ReadOnlySpan<HostAsmFx> ViewHosts
        {
            [MethodImpl(Inline)]
            get => _Hosts.View;
        }

        public Span<HostAsmFx> Edit
        {
            [MethodImpl(Inline)]
            get => _Hosts.Edit;
        }

        public ref HostAsmFx this[int index]
        {
            [MethodImpl(Inline)]
            get => ref _Hosts[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => _Hosts.Length;
        }


        public uint HostCount
        {
            [MethodImpl(Inline)]
            get => _Hosts.Count;
        }

        /// <summary>
        /// The total instruction count
        /// </summary>
        public uint InstructionCount
            => (uint)_Hosts.Storage.Sum(i => (long)i.InstructionCount);

        public ApiInstruction[] Instructions
            => _Hosts.Storage.SelectMany(x => x.Routines).SelectMany(x => x.Instructions.Storage).OrderBy(x => x.IP).Array();
    }
}