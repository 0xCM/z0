//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    /// <summary>
    /// Assocates an operation api identifier with executable code
    /// </summary>
    public readonly struct ApiCode : IByteSpanProvider<ApiCode>, IFormattable<ApiCode>
    {
        public static ApiCode Empty => new ApiCode(OpIdentity.Empty, BinaryCode.Empty);
        
        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static ApiCode Define(OpIdentity id, byte[] data)
            => new ApiCode(id,data);        

        [MethodImpl(Inline)]
        public ApiCode(OpIdentity id, in BinaryCode data)
        {
            this.Id = id;
            this.Data = data;
        }

        public readonly BinaryCode Data;

        public readonly OpIdentity Id;

        public ReadOnlySpan<byte> Bytes 
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty && Id.IsEmpty;
        }

        public string Format()
            => Data.Format();
    }
}