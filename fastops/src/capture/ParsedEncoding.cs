//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct ParsedEncoding
    {
        [MethodImpl(Inline)]
        public static ParsedEncoding Define(OpDescriptor op, CaptureOutcome capture, EncodedData parsed)
            => new ParsedEncoding(op,capture,parsed);

        [MethodImpl(Inline)]
        ParsedEncoding(OpDescriptor op, CaptureOutcome capture, EncodedData parsed)
        {
            this.Operation = op;
            this.CaptureResult = capture;
            this.ParsedData = parsed;
        }

        public readonly OpDescriptor Operation;        

        public readonly CaptureOutcome CaptureResult;
        
        public readonly EncodedData ParsedData;   

        public MemoryRange AddressRange
            => ParsedData.AddressRange;

    }
}