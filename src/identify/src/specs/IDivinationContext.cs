//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IDivinationContext : IContext
    {
        IMultiDiviner Diviner {get;}           
    }

    public readonly struct DivinationContext : IDivinationContext
    {   
        [MethodImpl(Inline)]
        public static IDivinationContext Create(IContext context, IMultiDiviner diviner)
            => new DivinationContext(diviner);

        [MethodImpl(Inline)]
        DivinationContext(IMultiDiviner diviner)
        {
            this.Diviner = diviner;
        }

        public IMultiDiviner Diviner {get;}           
    }
}