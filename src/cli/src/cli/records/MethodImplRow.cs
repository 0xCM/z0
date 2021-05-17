//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodImplRow : ICliRecord<MethodImplRow>
        {
            /// <summary>
            /// An index into the TypeDef table
            /// </summary>
            public CliRowKey Class;

            /// <summary>
            /// An index into the MethodDef or MemberRef table
            /// </summary>
            public CliRowKey MethodBody;

            /// <summary>
            /// an index into the MethodDef or MemberRef table
            /// </summary>
            public CliRowKey MethodDecl;
        }
    }
}