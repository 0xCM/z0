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
    public readonly struct PartInstructions
    {
        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part {get;}

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public readonly HostInstructions[] Data;

        [MethodImpl(Inline)]        
        public PartInstructions(PartId part, HostInstructions[] src)
        {
            Part = part;
            Data = src;
        }        

        public ReadOnlySpan<HostInstructions> View
        {
            [MethodImpl(Inline)] 
            get => Data;
        }

        public Span<HostInstructions> Edit
        {
            [MethodImpl(Inline)] 
            get => Data;
        }

        public ref HostInstructions this[int index] 
        {
            [MethodImpl(Inline)] 
            get => ref Data[index];
        }

        public int Length 
        {
            [MethodImpl(Inline)] 
            get => Data.Length;
        }

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int TotalCount 
            => Data.Sum(i => i.TotalCount); 

        public IEnumerable<LocatedAsmFx> Located
            => Data.SelectMany(x => x.Data).SelectMany(x => x.Content).OrderBy(x => x.IP);
    }
}