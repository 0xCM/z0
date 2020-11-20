//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiData, true)]
    public readonly struct ApiCode
    {
        [MethodImpl(Inline), Op]
        public static BinaryCode define(byte[] data)
            => new BinaryCode(data);

        [MethodImpl(Inline), Op]
        public static ApiMemberCode define(in ApiMember member, in ApiCodeBlock data)
            => new ApiMemberCode(member, data);

        [MethodImpl(Inline), Op]
        public static ApiCaptureBlock define(OpIdentity id, MethodInfo method, BasedCodeBlock extracted, BasedCodeBlock parsed, ExtractTermCode term)
            => new ApiCaptureBlock(id, method, extracted, parsed, term);

        [MethodImpl(Inline), Op]
        public static ApiPartCodeBlocks combine(PartId part, ApiHostCodeBlocks[] src)
            => new ApiPartCodeBlocks(part,src);

        /// <summary>
        /// Determines whether an operation accepts an argument of specified numeric kind
        /// </summary>
        /// <param name="src">The encoded operation</param>
        /// <param name="match">The kind to match</param>
        [Op]
        public static bool accepts(ApiCodeBlock src, NumericKind match)
            => ApiIdentify.numeric(src.Id.TextComponents.Skip(1)).Contains(match);

        /// <summary>
        /// Determines the arity of the encoded operation
        /// </summary>
        /// <param name="src">The encoded operation</param>
        [MethodImpl(Inline), Op]
        public static int arity(ApiCodeBlock src)
            => src.OpUri.OpId.TextComponents.Count() - 1;

        /// <summary>
        /// Excludes source operations that do not accept two parameters of specified numeric kind
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="k1">The first parameter kind</param>
        /// <param name="k2">The second parameter kind</param>
        public static IEnumerable<ApiCodeBlock> accepts(IEnumerable<ApiCodeBlock> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = ApiIdentify.numeric(code.OpUri.OpId.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        [Op]
        public static IEnumerable<ApiCodeBlock> accepts(IEnumerable<ApiCodeBlock> src, NumericKind kind)
            => from code in src
                where ApiCode.accepts(code, kind)
                select code;

        [Op]
        public static IEnumerable<ApiCodeBlock> withArity(IEnumerable<ApiCodeBlock> src, int count)
            => from code in src
                where ApiCode.arity(code) == count
                select code;


        [MethodImpl(Inline), Op]
        public static ApiCodeDescriptor descriptor(in ApiCodeBlock src)
        {
            var dst = new ApiCodeDescriptor();
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberEntity entity(in ApiMember src)
        {
            var dst = new ApiMemberEntity();
            return store(src,ref dst);
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberEntity entity(ApiMember src)
            => entity(in src);

        [Op]
        public static ApiHostMemberEntities entities(in ApiHostCatalog src)
        {
            var dst = new ApiHostMemberEntities();
            dst.Host = src.Host.Uri;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiMemberEntity store(in ApiMember src, ref ApiMemberEntity dst)
        {
            dst.Address = src.Address;
            dst.MetaUri = src.MetaUri;
            dst.ApiKind = src.ApiKind;
            dst.Host = src.Host;
            dst.Cil = src.Cil;
            return ref dst;
        }
    }
}