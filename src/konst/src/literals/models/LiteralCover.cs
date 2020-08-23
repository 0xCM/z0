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

    public struct LiteralCover
    {
        public ValueType Cover;

        public FieldInfo[] Covered {get;}

        [MethodImpl(Inline)]
        public LiteralCover(ValueType cover, FieldInfo[] covered)
        {
            Cover = cover;
            Covered = covered;
        }

        [MethodImpl(Inline)]
        public void WriteValues(Span<object> dst)
        {
            var view = z.@readonly(Covered);
            var count = view.Length;
            var tRef = __makeref(Cover);
            ref var target = ref z.first(dst);
            for(var i=0u; i<Covered.Length; i++)
                z.seek(dst,i) = z.skip(view,i).GetValueDirect(tRef);
        }
    }
}