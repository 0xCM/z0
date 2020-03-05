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
        public readonly OpDescriptor Operation;        

        public readonly CaptureTermCode TermCode;

        public readonly MemoryEncoding ParsedData;   

        [MethodImpl(Inline)]
        public static ParsedEncoding Define(OpDescriptor op, CaptureTermCode term, MemoryEncoding parsed)
            => new ParsedEncoding(op,term,parsed);

        [MethodImpl(Inline)]
        ParsedEncoding(OpDescriptor op, CaptureTermCode term, MemoryEncoding parsed)
        {
            this.Operation = op;
            this.ParsedData = parsed;
            this.TermCode = term;
        }        
    }
}