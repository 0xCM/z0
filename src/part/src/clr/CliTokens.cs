//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    public readonly struct CliTokens
    {
        [MethodImpl(Inline), Op]
        public static CliToken token(Handle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static CliToken token(EntityHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static CliToken token(TableIndex table, uint row)
            => new CliToken(((uint)table << 24) | (0xFFFFFF &  row));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static CliToken token<T>()
            => new CliToken(typeof(T));

        [MethodImpl(Inline), Op]
        public static CliToken token(Type src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(FieldInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(PropertyInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(MethodInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(ParameterInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(Assembly src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static string @string(Module module, CliToken token)
            => module.ResolveString((int)token);

        [MethodImpl(Inline), Op]
        public static BinaryCode sig(Module src, CliToken token)
            => src.ResolveSignature((int)token);

        [MethodImpl(Inline), Op]
        public static MethodBase method(Module src, CliToken token)
            => src.ResolveMethod((int)token);

        [MethodImpl(Inline), Op]
        public static MemberInfo member(Module src, CliToken token)
            => src.ResolveMember((int)token);

        [MethodImpl(Inline), Op]
        public static FieldInfo field(Module src, CliToken token)
            => src.ResolveField((int)token);

        [MethodImpl(Inline), Op]
        public static Type type(Module src, CliToken token)
            => src.ResolveType((int)token);

        [Op]
        public static Outcome parse(string src, out CliToken dst)
        {
            var i = text.index(src,Chars.Colon);
            var outcome = Outcome.Empty;
            dst = CliToken.Empty;
            if(i != NotFound)
            {
                outcome = HexNumericParser.parse8u(src.LeftOfIndex(i), out var table);
                if(!outcome)
                    return outcome;

                outcome = HexNumericParser.parse32u(text.right(src,i), out var row);
                if(!outcome)
                    return outcome;

                dst = token((TableIndex)table, row);
                return true;
            }
            else
            {
                outcome = HexNumericParser.parse32u(src, out var token);
                if(!outcome)
                    return outcome;
                dst = token;
                return true;
            }
        }
    }
}