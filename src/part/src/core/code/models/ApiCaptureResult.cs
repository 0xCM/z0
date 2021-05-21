//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiCaptureResult
    {
        /// <summary>
        /// The capture termination code indicating why the capture process reached end-state
        /// </summary>
        public ExtractTermCode TermCode {get;}

        public CodeBlockPair Pair {get;}

        public MemoryRange CaptureRange {get;}

        [MethodImpl(Inline)]
        internal ApiCaptureResult(ExtractTermCode term,  MemoryRange range, CodeBlockPair pair)
        {
            TermCode = term;
            Pair = pair;
            CaptureRange = range;
        }
    }
}