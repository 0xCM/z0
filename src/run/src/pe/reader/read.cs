//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;
    using System.IO;

    using static ImageTables;

    partial struct ImageReader
    {
        public static ref ImageContent read(Stream src, bool @virtual, out ImageContent dst)
        {
            dst = default;
            try
            {
                using var source = new SourceStream(src, @virtual);
                var reader = new PeImageReader(source);
                ref var image = ref reader.Read(source, ref dst);
            }
            catch(Exception)
            {
                //receiver.Deposit(AppErrors.define(nameof(PeImageReader), e));
            }
            return ref dst;
        }

    }

}