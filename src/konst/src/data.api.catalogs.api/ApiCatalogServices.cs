//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static z;

    [ApiHost(ApiNames.ApiCatalogServices, true)]
    public readonly struct ApiCatalogServices
    {
        [MethodImpl(Inline), Op]
        public static ApiUriParser UriParser()
            => new ApiUriParser();

        [MethodImpl(Inline), Op]
        public static ApiPartIdParser PartIdParser()
            => new ApiPartIdParser();

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder CodeIdentity()
            => LegalIdentity(CodeIdentityOptions());

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder FileIdentity()
            => LegalIdentity(FileIdentityOptions());

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder LegalIdentity(LegalIdentityOptions options)
            => new LegalIdentityBuilder(options);

        [MethodImpl(Inline), Op]
        public static ApiIdentityManager IdentityManager(IWfShell wf)
            => new ApiIdentityManager(wf);

        [MethodImpl(Inline)]
        static LegalIdentityOptions FileIdentityOptions()
            => new LegalIdentityOptions(
                TypeArgsOpen: Chars.LBracket,
                TypeArgsClose: Chars.RBracket,
                ArgsOpen: Chars.LParen,
                ArgsClose: Chars.RParen,
                ArgSep: Chars.Comma,
                ModSep: IDI.ModSep);

        [MethodImpl(Inline)]
        internal static LegalIdentityOptions CodeIdentityOptions()
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