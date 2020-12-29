//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiMemberIdentifier : IIdentifier<ApiMemberIdentifier, StringRef>
    {
        public static ApiMemberIdentifier create(in OpIdentity src)
            => legalize(src, CreateCodeOptions());

        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        public ApiMemberIdentifier(string src)
            => Identifier = string.Intern(src ?? EmptyString);

        [MethodImpl(Inline)]
        public string Format()
            => Identifier;

        [MethodImpl(Inline)]
        public bool Equals(ApiMemberIdentifier src)
            => Identifier.Equals(src.Identifier);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is ApiMemberIdentifier x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberIdentifier(string src)
            => new ApiMemberIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberIdentifier(OpIdentity src)
            => create(src);

        [MethodImpl(Inline)]
        static LegalIdentityBuilder service(LegalIdentityOptions options)
            => new LegalIdentityBuilder(options);

        [MethodImpl(Inline)]
        static LegalIdentityOptions CreateCodeOptions()
            => new LegalIdentityOptions(
            TypeArgsOpen: SymNot.Lt,
            TypeArgsClose: SymNot.Gt,
            ArgsOpen: SymNot.Circle,
            ArgsClose: SymNot.Circle,
            ArgSep: SymNot.Dot,
            ModSep: (char)SymNotKind.Plus
            );

        [Op]
        public static ApiMemberIdentifier legalize(in OpIdentity src, in LegalIdentityOptions options)
        {
            var length = src.Identifier.Length;
            Span<char> dst = stackalloc char[length];
            for(var i=0; i<length; i++)
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

                    case Chars.Underscore:
                        dst[i] = c;
                        break;

                    default:
                        if(char.IsLetterOrDigit(c))
                            dst[i] = c;
                        else
                            corefunc.@throw(new Exception($"Unexpected character {c} in api text"));
                    break;
                }
            }
            return new string(dst.Trim());
        }
    }
}