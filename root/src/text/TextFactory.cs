//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    public interface ITextFactory : IFactory<string>
    {
        
    }
    
    public readonly struct TextFactory : ITextFactory
    {
        [MethodImpl(Inline)]
        public static TextFactory From(IFactory<string> src)
            =>  new TextFactory(src);

        readonly IFactory<string> Ops;
        
        [MethodImpl(Inline)]
        TextFactory(IFactory<string> src)
            => Ops = src;
    }

    public static class TextFactoryOps
    {

        [MethodImpl(Inline)]
        public static StringBuilder Builder(this IFactory<string> src)        
            => new StringBuilder();
    }
}
