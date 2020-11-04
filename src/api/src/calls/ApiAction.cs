//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiAction
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiAction<A0>
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;

        /// <summary>
        /// The first operand
        /// </summary>
        public A0 Arg0;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiAction<A0,A1>
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;

        /// <summary>
        /// The first operand
        /// </summary>
        public A0 Arg0;

        /// <summary>
        /// The second operand
        /// </summary>
        public A1 Arg1;
    }
}