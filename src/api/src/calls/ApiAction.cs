//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiAction
    {
        /// <summary>
        /// The operation class
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