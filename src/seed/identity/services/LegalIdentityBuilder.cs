//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct LegalIdentityBuilder : ILegalIdentityBuilder
    {
        static LegalIdentityOptions CodeOptions
            => new LegalIdentityOptions(
                TypeArgsOpen: SymNot.Lt, 
                TypeArgsClose: SymNot.Gt, 
                ArgsOpen: SymNot.Circle, 
                ArgsClose: SymNot.Circle, 
                ArgSep: SymNot.Dot);

        static LegalIdentityOptions FileOptions
            => new LegalIdentityOptions(
                TypeArgsOpen: Chars.LBracket, 
                TypeArgsClose: Chars.RBracket, 
                ArgsOpen: Chars.LParen, 
                ArgsClose: Chars.RParen, 
                ArgSep: Chars.Comma);

        public static string code(OpIdentity src)
            => LegalIdentityBuilder.Service(CodeOptions).Manufacture(src);

        public static string file(OpIdentity src)
            => LegalIdentityBuilder.Service(FileOptions).Manufacture(src);    
                            
        [MethodImpl(Inline)]
        public static LegalIdentityBuilder Service(LegalIdentityOptions options) 
            => new LegalIdentityBuilder(options);
        
        [MethodImpl(Inline)]
        public LegalIdentityBuilder(LegalIdentityOptions options)
        {
            Options = options;
        }

        readonly LegalIdentityOptions Options;        

        public string Manufacture(OpIdentity src)
        {
            var length = src.Identifier.Length;
            Span<char> dst = stackalloc char[length];
            for(var i=0; i< length; i++)
            {
                var c = src.Identifier[i];
                switch(c)
                {
                    case IDI.TypeArgsOpen:
                        dst[i] = Options.TypeArgsOpen;
                    break;
                    case IDI.TypeArgsClose:
                        dst[i] = Options.TypeArgsClose;
                    break;
                    case IDI.ArgsOpen:
                        dst[i] = Options.ArgsOpen;
                    break;
                    case IDI.ArgsClose:
                        dst[i] = Options.ArgsClose;
                    break;
                    case IDI.ArgSep:
                        dst[i] = Options.ArgSep;
                    break;
                    default:
                        dst[i] = c;
                    break;
                }
            }
            return new string(dst.Trim());
        }
    }
}