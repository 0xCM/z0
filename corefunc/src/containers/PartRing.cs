//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static refs;

    /// <summary>
    /// Defines a mutable circular S-cell buffer partitioned into T-cell parts
    /// </summary>
    public ref struct PartRing<S,T>
        where T : unmanaged
    {
        internal PartRing(Span<S> src)
        {
            this.data = src;
            this.partwidth = size<T>();
            this.parts = src.Length/partwidth;
            this.CurrentPart = 0;            
        }
        
        readonly Span<S> data;

        readonly int parts;
        
        readonly int partwidth;

        int CurrentPart;

        public ref T Next
        {
            [MethodImpl(Inline)]
            get
            {
                if(CurrentPart == parts)
                    CurrentPart = 0;

                ref var next = ref seek(ref head(data), CurrentPart*partwidth);
                CurrentPart++;
                return ref Unsafe.As<S,T>(ref next);
            }
        }

        public ReadOnlySpan<S> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

    }
}
