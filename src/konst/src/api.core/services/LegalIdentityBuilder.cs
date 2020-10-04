//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = ApiIdentify;

    public struct LegalIdentityBuilder : IIdentityBuilder<string,OpIdentity>
    {
        LegalIdentityOptions Options;

        readonly LegalIdentityOptions CodeOptions;

        readonly LegalIdentityOptions FileOptions;

        [MethodImpl(Inline)]
        public static string code(OpIdentity src)
            => service(CreateCodeOptions()).Build(src);

        [MethodImpl(Inline)]
        public static string file(OpIdentity src)
            => service(CreateFileOptions()).Build(src);

        [MethodImpl(Inline)]
        public static LegalIdentityBuilder service(LegalIdentityOptions options)
            => new LegalIdentityBuilder(options);

        [MethodImpl(Inline)]
        internal LegalIdentityBuilder(LegalIdentityOptions options)
        {
            Options = options;
            CodeOptions = CreateCodeOptions();
            FileOptions = CreateFileOptions();
        }

        public string Build(OpIdentity src)
            => api.legalize(src,Options);

        [MethodImpl(Inline)]
        internal static LegalIdentityOptions CreateFileOptions()
            => new LegalIdentityOptions(
                TypeArgsOpen: Chars.LBracket,
                TypeArgsClose: Chars.RBracket,
                ArgsOpen: Chars.LParen,
                ArgsClose: Chars.RParen,
                ArgSep: Chars.Comma,
                ModSep: IDI.ModSep);

        [MethodImpl(Inline)]
        internal static LegalIdentityOptions CreateCodeOptions()
            => new LegalIdentityOptions(
            TypeArgsOpen: SymNot.Lt,
            TypeArgsClose: SymNot.Gt,
            ArgsOpen: SymNot.Circle,
            ArgsClose: SymNot.Circle,
            ArgSep: SymNot.Dot,
            ModSep: (char)SymNotKind.Plus
            );
    }
}