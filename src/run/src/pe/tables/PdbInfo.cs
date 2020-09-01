//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ImageTables
    {
        /// <summary>
        /// Information about a specific PDB instance obtained from a PE image.
        /// </summary>
        public struct PdbInfo
        {
            /// <summary>
            /// Gets the Guid of the PDB.
            /// </summary>
            public Guid Guid;

            /// <summary>
            /// Gets the PDB revision.
            /// </summary>
            public int Revision;

            /// <summary>
            /// Gets the path to the PDB.
            /// </summary>
            public string Path;
        }
    }
}