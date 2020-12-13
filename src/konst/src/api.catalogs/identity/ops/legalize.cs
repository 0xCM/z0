//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiIdentify
    {
        [Op]
        public static string legalize(OpIdentity src, in LegalIdentityOptions options)
        {
            var length = src.Identifier.Length;
            Span<char> dst = stackalloc char[length];
            for(var i=0; i< length; i++)
            {
                var c = src.Identifier[i];
                switch(c)
                {
                    case IDI.TypeArgsOpen:
                        dst[i] = options.TypeArgsOpen;
                    break;

                    case IDI.TypeArgsClose:
                        dst[i] = options.TypeArgsClose;
                    break;

                    case IDI.ArgsOpen:
                        dst[i] = options.ArgsOpen;
                    break;

                    case IDI.ArgsClose:
                        dst[i] = options.ArgsClose;
                    break;

                    case IDI.ArgSep:
                        dst[i] = options.ArgSep;
                    break;

                    case IDI.ModSep:
                        dst[i] = options.ModSep;
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
    }
}