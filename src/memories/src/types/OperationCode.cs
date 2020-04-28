//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Assocates an operation api identifier with executable code
    /// </summary>
    public readonly struct OperationCode : IEncoded<OperationCode,BinaryCode>, IOperationalIdentity
    {
        public OpIdentity Id {get;}

        public BinaryCode Content {get;}

        public static OperationCode Empty => new OperationCode(OpIdentity.Empty, BinaryCode.Empty);
        
        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static OperationCode Define(OpIdentity id, byte[] data)
            => new OperationCode(id,data);        

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(OperationCode src)
            => src.Content;

        [MethodImpl(Inline)]
        public OperationCode(OpIdentity id, in BinaryCode data)
        {
            this.Id = id;
            this.Content = data;
        }

        public ReadOnlySpan<byte> Bytes 
        {
            [MethodImpl(Inline)]
            get => Content.Bytes;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty && Id.IsEmpty;
        }

        public string Format()
            => Content.Format();         

        
        public bool Equals(OperationCode src)
            => Content.Equals(src.Content);
    }
}