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

    /// <summary>
    /// Represents a call to a classified operation that accepts no arguments
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;
    }

    /// <summary>
    /// Represents a call to a classified operation that accepts 1 argument
    /// </summary>
    /// <typeparam name="A0">The argument type</typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0>
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

    /// <summary>
    /// Represents a call to a classified operation that accepts 2 arguments
    /// </summary>
    /// <typeparam name="A0">The first argument type</typeparam>
    /// <typeparam name="A1">The second argument type</typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1>
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

    /// <summary>
    /// Represents a call to a classified operation that accepts 3 arguments
    /// </summary>
    /// <typeparam name="A0">The first argument type</typeparam>
    /// <typeparam name="A1">The second argument type</typeparam>
    /// <typeparam name="A2">The third argument type</typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1,A2>
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

        /// <summary>
        /// The third operand
        /// </summary>
        public A2 Arg2;
    }

    /// <summary>
    /// Represents a call to a classified operation that accepts 4 arguments
    /// </summary>
    /// <typeparam name="A0">The first argument type</typeparam>
    /// <typeparam name="A1">The second argument type</typeparam>
    /// <typeparam name="A2">The third argument type</typeparam>
    /// <typeparam name="A3">The fourth argument type</typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1,A2,A3>
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

        /// <summary>
        /// The third operand
        /// </summary>
        public A2 Arg2;

        /// <summary>
        /// The fourth operand
        /// </summary>
        public A3 Arg3;
    }
}