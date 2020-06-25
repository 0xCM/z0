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
    public readonly struct PartInstructions: IIndex<HostInstructions>
    {

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public HostInstructions[] Content {get;}

        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part {get;}

        public ref HostInstructions this[int index] 
        {
            get => ref Content[index];
        }

        public int Length { [MethodImpl(Inline)] get => Content.Length;}

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int TotalCount => Content.Sum(i => i.TotalCount);

        [MethodImpl(Inline)]
        public static PartInstructions Create(PartId part, HostInstructions[] src)
            => new PartInstructions(part, src);
    
        [MethodImpl(Inline)]        
        public PartInstructions(PartId part, HostInstructions[] inxs)
        {
            Part = part;
            Content = inxs;
        }

        public static PartInstructions Empty 
            => new PartInstructions(PartId.None, Array.Empty<HostInstructions>());

    }
}