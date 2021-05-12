//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using Dst = System.Reflection.Metadata;
    using Src = SRM;

    partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static ref Dst.Handle outer(in Src.Handle src, ref Dst.Handle dst)
        {
            dst = @as<Src.Handle,Dst.Handle>(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Dst.UserStringHandle outer(in Src.UserStringHandle src, ref Dst.UserStringHandle dst)
        {
            dst = @as<Src.UserStringHandle,Dst.UserStringHandle>(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Dst.StringHandle outer(in Src.StringHandle src, ref Dst.StringHandle dst)
        {
            dst = @as<Src.StringHandle,Dst.StringHandle>(src);
            return ref dst;
        }
    }
}