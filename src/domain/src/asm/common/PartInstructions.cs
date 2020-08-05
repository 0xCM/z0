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
    public readonly struct PartInstructions: IContentedIndex<HostInstructions>
    {
        /// <summary>
        /// The decoded instructions
        /// </summary>
        public HostInstructions[] Content {get;}

        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part {get;}

        [MethodImpl(Inline)]        
        public PartInstructions(PartId part, HostInstructions[] inxs)
        {
            Part = part;
            Content = inxs;
        }        
        
        public ref HostInstructions this[int index] 
        {
            [MethodImpl(Inline)] 
            get => ref Content[index];
        }

        public int Length 
        {
            [MethodImpl(Inline)] 
            get => Content.Length;
        }

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int TotalCount 
            => Content.Sum(i => i.TotalCount);
    
        public static PartInstructions Empty 
            => new PartInstructions(PartId.None, Array.Empty<HostInstructions>());
    }
}