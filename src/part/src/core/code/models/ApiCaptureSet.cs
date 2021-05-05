//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class ApiCaptureSet
    {
        public OpUri Id {get;}

        public MsilSourceBlock Msil {get;}

        public CodeBlock Hex {get;}

        public AsmSourceBlock Asm {get;}

        public MethodDisplaySig DisplaySig {get;}

        [MethodImpl(Inline)]
        public ApiCaptureSet(in OpUri id, in MsilSourceBlock msil,  in CodeBlock hex, in AsmSourceBlock asm, in MethodDisplaySig sig)
        {
            Id = id;
            Msil = msil;
            Hex = hex;
            Asm = asm;
            DisplaySig = sig;
        }

        public bool Complete
        {
            [MethodImpl(Inline)]
            get => Msil.Complete && Id.IsNonEmpty && Hex.IsNonEmpty && Asm.IsNonEmpty;
        }

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => Id.Part;
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => Id.Host;
        }

        public ByteSize HexSize
        {
            [MethodImpl(Inline)]
            get => Hex.Size;
        }

        public ByteSize MsilSize
        {
            [MethodImpl(Inline)]
            get => Msil.Size;
        }

        public CliSig CliSig
        {
            [MethodImpl(Inline)]
            get => Msil.Sig;
        }
    }
}