//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;
    using static memory;
    using static Rules;
    using static TextRules;

    struct AsmSigSymbolCache
    {
        const char DigitQualifier = FSlash;

        public static AsmSigSymbolCache create()
        {
            var dst = new AsmSigSymbolCache();
            dst.RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            dst.RegDigitRule = Rules.adjacent(DigitQualifier, oneof(dst.RegDigits));
            return dst;
        }

        public Index<char> RegDigits;

        public Adjacent<char, OneOf<char>> RegDigitRule;
    }

    [ApiHost]
    public class AsmSigs : WfService<AsmSigs>
    {
        const char DigitQualifier = FSlash;

        readonly AsmSigSymbolCache Cache;

        readonly Symbols<AsmMnemonicCode> MnemonicSyms;

        public AsmSigs()
        {
            Cache = AsmSigSymbolCache.create();
            MnemonicSyms = Symbols.cache<AsmMnemonicCode>();
        }

        void DefineSubstitutions()
        {

        }

        [MethodImpl(Inline), Op]
        public Symbols<AsmMnemonicCode> Mnemonics()
            => MnemonicSyms;

        [Op,Closures(UInt64k)]
        void ShowSymbols<T>(Symbols<T> src, ShowLog dst)
            where T : unmanaged
        {
            var count = src.Count;
            var symbols = src.View;
            for(var i=0; i<count; i++)
                dst.Show(skip(symbols,i).Format());
        }

        public void ShowSymbols()
        {
            var header = Symbols.header();
            using var monics = ShowLog("sig-mnemonics", FS.Csv);
            monics.Show(header);
            ShowSymbols(Mnemonics(), monics);
        }


        [Op]
        public bool IsDigit(AsmOpCodeExpr src)
        {
            var s = src.Content;
            return s.Length >= 2
                && @char(s) == DigitQualifier
                && Query.test(@char(s,1), Rules.oneof(Cache.RegDigits));
        }


        public static bool rule(string src, Adjacent<char, OneOf<char>> rule, out Adjacent<char> dst)
        {
            var match = rule.A;
            var candidates = rule.B.Elements.View;
            var count = candidates.Length;
            var ix = text.index(candidates, rule.A);
            if(ix != NotFound)
            {
                dst = adjacent<char>(match, skip(candidates,ix));
                return true;
            }
            dst = default;
            return false;
        }

        [Op]
        public bool ParseDigit(string src, out RegDigit dst)
        {
            dst = default;
            if(rule(src, Cache.RegDigitRule, out var result) &&
                text.digit(result.B, out var digit))
                    return assign(digit, out dst);
            return false;
        }
    }
}