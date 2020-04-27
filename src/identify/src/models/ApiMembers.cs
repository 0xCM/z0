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

    using static Seed;

    /// <summary>
    /// A simple api member sequence adapter
    /// </summary>
    public readonly struct ApiMembers : IIndexContainer<Member>
    {
        public Member[] Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator ApiMembers(Member[] src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator Member[](ApiMembers src)
            => src.Content;

        [MethodImpl(Inline)]
        public static ApiMembers Define(params Member[] src)
            => new ApiMembers(src);

        [MethodImpl(Inline)]
        public ApiMembers(params Member[] src)
        {
            this.Content = src;
        }

        public int Length 
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }
    
        public ref Member this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Content[index];
        }

        public ApiMembers Where(Func<Member,bool> predicate)
            => Content.Where(predicate).ToArray();
    }
}