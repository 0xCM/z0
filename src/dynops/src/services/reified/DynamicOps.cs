//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    readonly struct DynamicOpsSvc : IInnerDynamic
    {
        readonly IMultiDiviner Diviner;      

        [MethodImpl(Inline)]
        public static DynamicOpsSvc Create(IDivinationContext context)
            => new DynamicOpsSvc(context);
    
        [MethodImpl(Inline)]
        DynamicOpsSvc(IDivinationContext context)
        {
            Diviner = context.Diviner;
        }            

        [MethodImpl(Inline)]
        public OpIdentity Identify(MethodInfo src)
            => Diviner.Identify(src);

        [MethodImpl(Inline)]
        public TypeIdentity Identify(Type src)
            => Diviner.Identify(src);

        [MethodImpl(Inline)]
        public OpIdentity Identify(Delegate src)
            => Diviner.Identify(src);
    }
}