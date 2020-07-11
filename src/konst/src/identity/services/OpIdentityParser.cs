//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static IDI;
    
    public interface TIdentityParser : IInfallibleParser<OpIdentity>
    {
        OpIdentity IInfallibleParser<OpIdentity>.Parse(string text)
            => OpIdentityParser.parse(text);
        
        OpIdentity INullary<OpIdentity>.Zero 
            => OpIdentity.Empty;
    }    
    
    public readonly struct OpIdentityParser : TIdentityParser
    {
        public static OpIdentityParser Service => default(OpIdentityParser);

        public static OpIdentity parse(string text)        
        {
            if(string.IsNullOrWhiteSpace(text))
                return OpIdentity.Empty;
            
            var src = text;
            var name = src.TakeBefore(PartSep);
            var suffixed = src.Contains(SuffixSep);
            var suffix = suffixed ? src.TakeAfter(IDI.SuffixSep) : string.Empty;
            var generic = src.TakeAfter(PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = src.SplitClean(PartSep);
            var id = OpIdentity.Define(src, name, suffix, generic, imm, components);
            return id;
        }
        
        public OpIdentity Parse(string text)
            => parse(text);
    }
}