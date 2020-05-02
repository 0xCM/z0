//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static IDI;
    
    public interface IIdentityParser : ISuccessfulParser<OpIdentity>, IStateless<OpIdentityParser,IIdentityParser>
    {
        [MethodImpl(Inline)]
        OpIdentity ISuccessfulParser<OpIdentity>.Parse(string text)
            => OpIdentityParser.Service.Parse(text);
        
        OpIdentity INullary<OpIdentity>.Zero => OpIdentity.Empty;
    }

    [Parser]
    public readonly struct OpIdentityParser : IIdentityParser
    {
        public static IIdentityParser Service => default(OpIdentityParser);
        
        public OpIdentity Parse(string text)
        {
            var src = text ?? 0.ToString();
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