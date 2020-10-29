//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using D = ApiData;

    public readonly partial struct ApiData
    {

    }

    public readonly struct ApiRecords
    {
        public static D.ApiMember from(in ApiMember src)
        {
            var dst = new D.ApiMember();
            dst.Address = src.Address;
            dst.MetaUri = src.MetaUri;
            dst.ApiKind = src.ApiKind;
            dst.Host = src.Host;
            dst.Cil = src.Cil;
            return dst;
        }

        public static D.ApiHostMembers from(in ApiHostMembers src)
        {
            var dst = new D.ApiHostMembers();
            dst.Host = src.Host.Uri;
            return dst;
        }
    }
}