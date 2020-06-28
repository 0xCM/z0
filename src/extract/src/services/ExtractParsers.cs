//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ExtractParsers
    {
        [MethodImpl(Inline), Op]
        public static BytePatternParser<EncodingPatternKind> pattern(byte[] buffer)        
            => new BytePatternParser<EncodingPatternKind>(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline), Op]
        public static IExtractParser member(byte[] buffer)
            => new MemberExtractParser(buffer);

        [MethodImpl(Inline), Op]
        public static IExtractParser member(ByteSize bufferlen)
            => new MemberExtractParser(sys.alloc<byte>(bufferlen));  

        [MethodImpl(Inline), Op]
        public static ParseResult<BinaryCode,LocatedCode> parse(in LocatedCode src, in BinaryCode buffer)
        {
            var parser = pattern(buffer);
            var status = parser.Parse(src);            
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded 
                ? ParseResult.Success(buffer, new LocatedCode(src.Address, parser.Parsed)) 
                : ParseResult.Fail<BinaryCode,LocatedCode>(buffer);
        }               

        [MethodImpl(Inline), Op]
        public static bool parse(in LocatedCode src, in BinaryCode buffer, out LocatedCode dst)
        {
            var result = parse(src, buffer);
            if(result.Succeeded)
                dst = result.Value;
            else
                dst = LocatedCode.Empty;
            return result.Succeeded;                
        }            
    }
}