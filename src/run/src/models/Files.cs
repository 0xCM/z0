//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct Files : IEnumerable<FilePath>
    {
        public static Files from(FilePath[] src)
            => new Files(src.Map(normalize));
        
        public readonly FilePath[] Data;

        [MethodImpl(Inline)]
        internal Files(FilePath[] src)    
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint) Data.Length;
        }
        
        public ref readonly FilePath this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        internal static FilePath normalize(FilePath src)
            => FilePath.Define(src.Name.Replace('\\', '/'));

        IEnumerator<FilePath> IEnumerable<FilePath>.GetEnumerator()
            => ((IEnumerable<FilePath>)Data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Data.GetEnumerator();
    }
}