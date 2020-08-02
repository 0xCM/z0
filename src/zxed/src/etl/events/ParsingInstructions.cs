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

    public readonly struct ParsingInstructions : IWfEvent<ParsingInstructions>
    {
        const string Pattern = "{0}: Parsing {1}";

        /// <summary>
        /// The event identifier
        /// </summary>
        public WfEventId Id {get;}

        /// <summary>
        /// The input file path
        /// </summary>
        public readonly FilePath Source;
        
        [MethodImpl(Inline)]
        public ParsingInstructions(WfEventId id, FilePath source)
        {
            Id = id;
            Source = source;
        }

        public string Format()
            => text.format(Pattern, Id, Source);
    }
}