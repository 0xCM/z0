//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;

    partial class ClassReps
    {
        public static Unary Unary => default;

        public static Binary Binary => default;

        public static Ternary Ternary => default;
        
        public static Unary<T> unary<T>() where T : unmanaged => default;

        public static Binary<T> binary<T>() where T : unmanaged => default;

        public static Ternary<T> ternary<T>() where T : unmanaged => default;
    }
}