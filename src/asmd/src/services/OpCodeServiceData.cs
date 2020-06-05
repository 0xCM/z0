//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    partial struct OpCodeServices
    {
        readonly OpCodeDataset Data;

        Token[] ITokens
        {
            [MethodImpl(Inline)]
            get => Data.ITokens;
        }

        string[] ITokenPurpose
        {
            [MethodImpl(Inline)]
            get => Data.ITokenPurpose;
        }

        string[] ITokenIdentity
        {
            [MethodImpl(Inline)]
            get => Data.ITokenIdentity;
        }

        string[] ITokenValues
        {
            [MethodImpl(Inline)]
            get => Data.ITokenValues;
        }

        int OpCodeCount
        {
            [MethodImpl(Inline)]
            get => Data.OpCodeCount;
        }
        
        OpCodeRecord[] Records
        {
            [MethodImpl(Inline)]
            get => Data.Records;
        }

        readonly OpCodeIdentifier[] OpCodeIdentifiers
        {
            [MethodImpl(Inline)]
            get => Data.OpCodeIdentifiers;
        }

        AppResourceDoc ResourceDoc
        {
            [MethodImpl(Inline)]
            get => Data.ResourceDoc;
        }

        [MethodImpl(Inline)]
        OpCodeServices(in OpCodeDataset data)
        {
            Data = data;
        }

        internal static Option<AppResourceDoc> LoadResource()
        {
            var extractor = ResExtractor.Service(typeof(OpCodeServices).Assembly);            
            var name = FileName.Define("OpCodeSpecs", FileExtensions.Csv);
            return extractor.ExtractDocument(name);
        }

        [MethodImpl(Inline)]
        public void GenCode()
        {
            ReadOnlySpan<OpCodeRecord> src = Records;
            for(var i=0; i<OpCodeCount; i++)
            {
                ref readonly var record = ref skip(src,i);
                var opcode = Parse(new OpCodeExpression(record.Expression));                
                var inxs = Parse(new InstructionExpression(record.Instruction));
            }            
        }
    }
}