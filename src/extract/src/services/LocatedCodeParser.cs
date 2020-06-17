//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Memories;
    
    public readonly struct LocatedCodeParser : ILocatedCodeParser
    {
        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static ILocatedCodeParser Create(byte[] buffer)
            => new LocatedCodeParser(buffer);

        [MethodImpl(Inline)]
        internal LocatedCodeParser(byte[] buffer)
        {
            Buffer = buffer;
        }

        public Option<LocatedCode> Parse(LocatedCode src)
        {
            var parser = Extract.Services.PatternParser(Buffer.Clear());
            var status = parser.Parse(src);            
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded 
                ? LocatedCode.Define(src.Address, parser.Parsed) 
                : none<LocatedCode>();
        }               
    }
}