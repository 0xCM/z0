//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    /// <summary>
    /// Collects sequences of instructions from host-defined members
    /// </summary>
    public readonly struct ApiHostRoutines
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Uri {get;}

        /// <summary>
        /// The base address of the first member, where members are ordered by their individual base addresses
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public ApiInstructionSet[] Routines {get;}

        /// <summary>
        /// The total instruction count
        /// </summary>
        public uint InstructionCount {get;}

        [MethodImpl(Inline)]
        public ApiHostRoutines(ApiHostUri host, ApiInstructionSet[] src)
        {
            Uri = host;
            Routines = src.OrderBy(x => x.BaseAddress).ToArray();
            BaseAddress = Routines.Length != 0 ? Routines[0].BaseAddress : MemoryAddress.Zero;
            InstructionCount = (uint)Routines.Sum(i => (long)i.InstructionCount);
        }

        /// <summary>
        /// The member instruction content length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Routines.Length;
        }

        /// <summary>
        /// Indexes into the member instruction content
        /// </summary>
        public ref ApiInstructionSet this[int index]
        {
            [MethodImpl(Inline)]
             get => ref Routines[index];
        }

        public uint RoutineCount
        {
            [MethodImpl(Inline)]
            get => (uint)Routines.Length;
        }
    }
}