//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct FileTypeList
    {
        readonly Type[] FileTypes;

        [MethodImpl(Inline)]
        public FileTypeList(Type[] src)
            => FileTypes = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)FileTypes.Length;
        }

        public ReadOnlySpan<Type> Reps
        {
            [MethodImpl(Inline)]
            get => FileTypes;
        }
    }
}