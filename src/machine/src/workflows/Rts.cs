//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Asm;
    using static Konst;

    [ApiHost]
    public readonly struct Rts
    {
        [MethodImpl(Inline), Op]
        public static T[] init<T>(RuntimeFieldHandle handle)
        {
            var dst = new T[]{};
            RuntimeHelpers.InitializeArray(dst,handle);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ulong[] data()
            => init<ulong>(typeof(Rts).Fields()[0].FieldHandle);

        public static readonly ulong[] Data 
            = new ulong[]{0,1,2,3,4,5,6,7,9,10,11,12,13,14,15};            
    }
}