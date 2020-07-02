//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Konst;
    using static ReflectionFlags;

    public readonly struct DefaultMethod
    {
        public static ref readonly MethodInfo Empty
            =>  ref DefaultMethod<ulong>.Empty;           
    }

    public readonly struct DefaultType
    {
        public static ref readonly Type Empty 
        {
            [MethodImpl(Inline)]
            get => ref typeof(Default<ulong>).GetNestedTypes(BF_NonPublic)[0];
        }             

        readonly struct Default<T> { }   
    }

    readonly struct DefaultMethod<T>
        where T : unmanaged
    {
        static void M(){}

        public static ref readonly MethodInfo Empty 
        {
            [MethodImpl(Inline)]
            get => ref typeof(DefaultMethod<T>).GetMethods(BF_NonPublicStatic)[0];
        }
    }
}