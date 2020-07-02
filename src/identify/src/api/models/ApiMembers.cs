//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines and index over <see cref='ApiMember'/> values
    /// </summary>
    public readonly struct ApiMembers : IIndex<ApiMember>
    {
        public readonly ApiMember[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiMembers(ApiMember[] src)
            => new ApiMembers(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiMember[](ApiMembers src)
            => src.Data;

        [MethodImpl(Inline)]
        public ApiMembers(params ApiMember[] src)
            => Data = src;

        public int Length 
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref ApiMember this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ApiMembers Where(Func<ApiMember,bool> predicate)
            => Data.Where(predicate).ToArray();

       ApiMember[] IContented<ApiMember[]>.Content 
            => Data;             
    }
}