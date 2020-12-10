//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static Konst;

    [ApiHost(ApiNames.ApiServices, true)]
    public readonly struct ApiServices
    {
        [Op]
        public static IDictionary<MethodInfo,Type> ClosureProviders(IEnumerable<Type> src)
        {
            var query = from t in src
                        from m in t.DeclaredStaticMethods()
                        let tag = m.Tag<ClosureProviderAttribute>()
                        where tag.IsSome()
                        select (m, tag.Value.ProviderType);
            return query.ToDictionary();
        }

        /// <summary>
        /// Factory for <see cref='ApiUriParser'/> services
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ApiUriParser UriParser()
            => new ApiUriParser();

        /// <summary>
        /// Factory for <see cref='ApiPartIdParser'/> services
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ApiPartIdParser PartIdParser()
            => new ApiPartIdParser();

        /// <summary>
        /// Factory for code identifier <see cref='LegalIdentityBuilder'/> services
        /// </summary>
        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder CodeIdentity()
            => LegalIdentity(CodeIdentityOptions());

        /// <summary>
        /// Factory for file identifier <see cref='LegalIdentityBuilder'/> services
        /// </summary>
        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder FileIdentity()
            => LegalIdentity(FileIdentityOptions());

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder LegalIdentity(LegalIdentityOptions options)
            => new LegalIdentityBuilder(options);

        [MethodImpl(Inline), Op]
        public static ApiIdentities IdentityManager(IWfShell wf)
            => new ApiIdentities(wf);

        [MethodImpl(Inline), Op]
        public static LegalIdentityOptions FileIdentityOptions()
            => new LegalIdentityOptions(
                TypeArgsOpen: Chars.LBracket,
                TypeArgsClose: Chars.RBracket,
                ArgsOpen: Chars.LParen,
                ArgsClose: Chars.RParen,
                ArgSep: Chars.Comma,
                ModSep: IDI.ModSep);

        [MethodImpl(Inline), Op]
        public static LegalIdentityOptions CodeIdentityOptions()
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