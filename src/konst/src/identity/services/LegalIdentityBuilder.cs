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
        readonly LegalIdentityOptions Options;        

        public static string code(OpIdentity src)
            => LegalIdentityBuilder.Service(CodeOptions).Manufacture(src);

        public static string file(OpIdentity src)
            => LegalIdentityBuilder.Service(FileOptions).Manufacture(src);    
                            
        [MethodImpl(Inline)]
        public static LegalIdentityBuilder Service(LegalIdentityOptions options) 
            => new LegalIdentityBuilder(options);
        
        [MethodImpl(Inline)]
        public LegalIdentityBuilder(LegalIdentityOptions options)
            => Options = options;

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
                    
                    case IDI.ModSep:
                        dst[i] = Options.ModSep;
                    break;
                    
                    case IDI.Refines:
                        dst[i] = (char)SymNotKind.Pipe;
                    break;
                    
                    case Chars.Dot:
                        dst[i] = (char)SymNotKind.Dot;
                        break;

                    case Chars.Gt:
                        dst[i] = (char)SymNotKind.Gt;
                        break;

                    case Chars.Lt:
                        dst[i] = (char)SymNotKind.Lt;
                        break;

                    default:
                        dst[i] = c;
                    break;
                }
            }
            return new string(dst.Trim());
        }


        static LegalIdentityOptions CodeOptions
            => new LegalIdentityOptions(
                TypeArgsOpen: SymNot.Lt, 
                TypeArgsClose: SymNot.Gt, 
                ArgsOpen: SymNot.Circle, 
                ArgsClose: SymNot.Circle, 
                ArgSep: SymNot.Dot,
                ModSep: (char)SymNotKind.Plus
                );

        static LegalIdentityOptions FileOptions
            => new LegalIdentityOptions(
                TypeArgsOpen: Chars.LBracket, 
                TypeArgsClose: Chars.RBracket, 
                ArgsOpen: Chars.LParen, 
                ArgsClose: Chars.RParen, 
                ArgSep: Chars.Comma,
                ModSep: IDI.ModSep);
    }
}