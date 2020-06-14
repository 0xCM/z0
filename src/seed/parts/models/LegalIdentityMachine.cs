//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct LegalIdentityMachine : ILegalIdentityMachine
    {
        [MethodImpl(Inline)]
        public static LegalIdentityMachine Service(ILegalIdentityOption options) 
            => new LegalIdentityMachine(options.TypeArgsOpen, options.TypeArgsClose, options.ArgsOpen, options.ArgsClose, options.ArgSep);
        
        [MethodImpl(Inline)]
        public LegalIdentityMachine(char TypeArgsOpen, char TypeArgsClose, char ArgsOpen, char ArgsClose, char ArgSep)
        {
            this.TypeArgsOpen = TypeArgsOpen;
            this.TypeArgsClose = TypeArgsClose;
            this.ArgsOpen = ArgsOpen;
            this.ArgsClose = ArgsClose;
            this.ArgSep = ArgSep;
        }
        
        public char TypeArgsOpen {get;}

        public char TypeArgsClose {get;}

        public char ArgsOpen {get;}

        public char ArgsClose {get;}

        public char ArgSep {get;}

        public string Manufacture(OpIdentity src)
        {
            var length = src.IdentityText.Length;
            Span<char> dst = stackalloc char[length];
            for(var i=0; i< length; i++)
            {
                var c = src.IdentityText[i];
                switch(c)
                {
                    case IDI.TypeArgsOpen:
                        dst[i] = TypeArgsOpen;
                    break;
                    case IDI.TypeArgsClose:
                        dst[i] = TypeArgsClose;
                    break;
                    case IDI.ArgsOpen:
                        dst[i] = ArgsOpen;
                    break;
                    case IDI.ArgsClose:
                        dst[i] = ArgsClose;
                    break;
                    case IDI.ArgSep:
                        dst[i] = ArgSep;
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