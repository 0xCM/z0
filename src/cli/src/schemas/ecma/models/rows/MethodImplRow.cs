//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(CliTableKind.MethodImpl), StructLayout(LayoutKind.Sequential)]
    public struct MethodImplRow
    {
        public RowKey Key;

        /// <summary>
        /// An index into the TypeDef table
        /// </summary>
        public RowKey Class;

        /// <summary>
        /// An index into the MethodDef or MemberRef table
        /// </summary>
        public RowKey MethodBody;

        /// <summary>
        /// an index into the MethodDef or MemberRef table
        /// </summary>
        public RowKey MethodDecl;
    }
}