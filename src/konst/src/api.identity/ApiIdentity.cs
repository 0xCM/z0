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

    using static Konst;
    using static z;

    public readonly struct ApiIdentity
    {
        readonly Cell128 Data;

        [MethodImpl(Inline)]
        public ApiIdentity(Cell128 src)
            => Data = src;

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => Cells.segment(Data, w16, out PartId _);
        }

        [MethodImpl(Inline)]
        public static ApiIdentity identify(MethodInfo src)
        {
            var host = src.DeclaringType;
            var dst = vparts(w128, (uint)host.Assembly.Id(), (uint)src.KindId(), (uint)host.MetadataToken, (uint)src.MetadataToken);
            return new ApiIdentity(dst);
        }
    }
}