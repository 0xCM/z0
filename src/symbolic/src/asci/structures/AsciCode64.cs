//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Typed;

    using N = N64;

    public readonly struct AsciCode64 : IAsciSequence<AsciCode64,N>
    {
        public static AsciCode64 Null => new AsciCode64(Vector512<byte>.Zero);

        internal readonly Vector512<byte> Data;        

        [MethodImpl(Inline)]
        public AsciCode64(Vector512<byte> src)
        {
            Data = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Data.Equals(default);
        }

        public AsciCode64 Zero
        {
            [MethodImpl(Inline)]
            get => default;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode64 src)
            => Data.Equals(src.Data);
 
         public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is AsciCode64 j && Equals(j);
    }

}
