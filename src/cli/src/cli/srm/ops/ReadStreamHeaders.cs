//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static core;

    partial class SRM
    {
        /// <summary>
        /// Reads stream headers described in ECMA-335 24.2.2 Stream header
        /// </summary>
        [Op]
        public static StreamHeader[] ReadStreamHeaders(ref BlobReader reader)
        {
            // storage header:
            reader.ReadUInt16();
            int streamCount = reader.ReadInt16();

            var streamHeaders = new StreamHeader[streamCount];
            for (int i = 0; i < streamHeaders.Length; i++)
            {
                if (reader.RemainingBytes < COR20Constants.MinimumSizeofStreamHeader)
                    return sys.empty<StreamHeader>();

                streamHeaders[i].Offset = reader.ReadUInt32();
                streamHeaders[i].Size = reader.ReadInt32();
                streamHeaders[i].Name = reader.ReadUtf8NullTerminated();

                // bool aligned = memReader.TryAlign(4);
                // if (!aligned || memReader.RemainingBytes == 0)
                // {
                //     return sys.empty<CliStreamHeader>();
                // }
            }

            return streamHeaders;
        }

    }
}