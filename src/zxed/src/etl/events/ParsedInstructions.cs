//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.XedWf
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsedInstructions : IWfEvent<ParsedInstructions>
    {
        const string Pattern = "{0}: Parsed {1} instructions from {2}";

        /// <summary>
        /// The event identifier
        /// </summary>
        public WfEventId Id {get;}

        /// <summary>
        /// The input file path
        /// </summary>
        public readonly FilePath Source;
        
        /// <summary>
        /// The number of instructions parsed from the source
        /// </summary>
        public readonly uint Count;
        
        [MethodImpl(Inline)]
        public ParsedInstructions(WfEventId id, FilePath source, uint count)
        {
            Id = id;
            Source = source;
            Count = count;
        }

        public string Format()
            => text.format(Pattern, Id, Count, Source);
    }
}