//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial struct FunctionModels
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref byte dst)
            => process<T,byte>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref sbyte dst)
            => process<T,sbyte>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref short dst)
            => process<T,short>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref ushort dst)
            => process<T,ushort>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref int dst)
            => process<T,int>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref uint dst)
            => process<T,uint>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref long dst)
            => process<T,long>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref float dst)
            => process<T,float>(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public void process<T>(ReadOnlySpan<T> src, ref double dst)
            => process<T,double>(src, ref dst);

        [MethodImpl(Inline)]
        public void process<S,T>(ReadOnlySpan<S> src, ref T dst) 
        {
            var k = 0;
            var srcCellSize = Unsafe.SizeOf<S>();
            ref var target = ref Unsafe.As<T,byte>(ref dst);                
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var source = ref Unsafe.As<S,byte>(ref edit(skip(src,i)));
                for(var j=0; j<srcCellSize; j++)
                    Unsafe.Add(ref target, k++) = skip(source, j);                    
            }
        }                
    }
}