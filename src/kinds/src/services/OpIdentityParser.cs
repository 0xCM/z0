//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static IDI;
    
    public interface IIdentityParser : IInfallibleParser<OpIdentity>, IStateless<OpIdentityParser,IIdentityParser>
    {
        [MethodImpl(Inline)]
        OpIdentity IInfallibleParser<OpIdentity>.Parse(string text)
            => OpIdentityParser.Service.Parse(text);
        
        OpIdentity INullary<OpIdentity>.Zero => OpIdentity.Empty;
    }

    public readonly struct OpIdentityParser : IIdentityParser
    {
        public static IIdentityParser Service => default(OpIdentityParser);
        
        public OpIdentity Parse(string text)
        {
            if(string.IsNullOrWhiteSpace(text))
                return OpIdentity.Empty;
            
            var src = text;
            var name = src.TakeBefore(PartSep);
            var suffixed = src.Contains(SuffixSep);
            var suffix = suffixed ? src.TakeAfter(IDI.SuffixSep) : string.Empty;
            var generic = src.TakeAfter(PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(Imm);
            var components = src.SplitClean(PartSep);
            var id = OpIdentity.Define(src, name, suffix, generic, imm, components);
            return id;
        }
    }
}