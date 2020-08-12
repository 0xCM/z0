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

    using api = FileSystem;

    public readonly partial struct FileKinds : ITextual
    {   
        readonly Type[] KindReps;

        [MethodImpl(Inline)]
        public FileKinds(Type[] reps)
        {
            KindReps = reps;            
        }

        public CellCount Count 
        {
            [MethodImpl(Inline)]
            get => KindReps.Length;
        }

        public ReadOnlySpan<Type> Reps
        {
            [MethodImpl(Inline)]
            get => KindReps;
        }        
                
        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);
    }
}