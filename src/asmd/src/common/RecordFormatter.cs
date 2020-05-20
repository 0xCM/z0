//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Asm.Data.OpKind;
    using static Seed;

    public class RecordFormatter
    {
        [MethodImpl(Inline)]
        public static string Render(bool src)
            => src ? CharText.D1 : CharText.D0;
        
        [MethodImpl(Inline)]
        public static string RenderHex(string src)
            => src.RemoveBlanks().BlockPartition(2,Chars.Space);

        [MethodImpl(Inline)]
        public static string RenderScale(int src)
            => src != 0 ? src.ToString() : string.Empty;
        
        [MethodImpl(Inline)]
        public static string RenderMemDxSize(int src)
            => src != 0 ? src.ToString() : string.Empty;
        
        [MethodImpl(Inline)]
        public static string RenderHex16(ushort src)
            => src == 0 ? string.Empty : src.FormatHex(true,false);

        [MethodImpl(Inline)]
        public static string RenderHex32(uint src)
            => src == 0 ? string.Empty : src.FormatHex(false,true, prespec:false);

        [MethodImpl(Inline)]
        public static string RenderHex64(ulong src)
            => src == 0 ? string.Empty : src.FormatHex(false,false);

        [MethodImpl(Inline)]
        public static string Render(Register src)
            => src != 0 ? src.ToString() : string.Empty;

        [MethodImpl(Inline)]
        public static string Render(MemorySize src)
            => src != 0 ? src.ToString() : string.Empty;

        public static string Render(OpKind src)
        {
            var si = SegIndicator.From(src);
            if(si.IsNonEmpty)
                return si.Format();

            var result = src switch{
                OpKind.Register => "reg",
                NearBranch16 => "branch16",
                NearBranch32 => "branch32",
                NearBranch64 => "branch64",
                FarBranch16 => "farbranch16",
                FarBranch32 => "farbranch32",
                Immediate8 => "imm8",
                Immediate8_2nd => "imm8x2",
                Immediate16 => "imm16",
                Immediate32 => "imm32",
                Immediate64 => "imm64",
                Immediate8to16 => "imm16i",
                Immediate8to32 => "imm32i",
                Immediate8to64 => "imm64i",
                Immediate32to64 => "imm32x64i",
                Memory64 => "mem64",
                Memory => "mem",
                    _ => src.ToString()
            };

            return result;
        }
    }

    readonly struct RecordFormatter<F> : IRecordFormatter<F>
        where F : unmanaged, Enum
    {        
        readonly StringBuilder State;

        readonly char FieldSep;

        public static IRecordFormatter<F> Service 
            => new RecordFormatter<F>(new StringBuilder());        
        
        [MethodImpl(Inline)]
        internal RecordFormatter(StringBuilder state, char sep = Chars.Pipe)
        {
            State = state;
            FieldSep = sep;
        }

        public void AppendField(F f, object content)
        {
            State.Append(RenderContent(content).PadRight(AsmRecords.Width(f)));
        }

        public void AppendField<T>(F f, T content)
            where T : ITextual
        {
            State.Append($"{content?.Format()}".PadRight(AsmRecords.Width(f)));
        }

        public void DelimitField(F f, object content, char delimiter)
        {            
            State.Append(rspace(delimiter));            
            State.Append(RenderContent(content).PadRight(AsmRecords.Width(f)));
        }

        static string RenderContent(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                rendered = Null.Value.Format();
            else if(content is ITextual t)
                rendered = t.Format();
            else
                rendered = content.ToString();
            return rendered;
        }

        [MethodImpl(Inline)]
        public void DelimitField(F f, object content)
            => DelimitField(f, content, FieldSep);        

        [MethodImpl(Inline)]
        public void DelimitSome<T>(F f, T content)
            where T : unmanaged, Enum
                => DelimitField(f, content.IsSome() 
                 ? content.ToString() 
                 : string.Empty, FieldSep);        

        [MethodImpl(Inline)]
        public void DelimitSome<T>(F f, T content, char delimiter)
            where T : unmanaged, Enum
                => DelimitField(f, content.IsSome()  ? content.ToString()  : string.Empty, delimiter);        

        public void DelimitField<T>(F f, T content, char delimiter)
            where T : ITextual
        {
            State.Append(rspace(delimiter));            
            State.Append($"{content?.Format()}".PadRight(AsmRecords.Width(f)));
        }

        [MethodImpl(Inline)]
        public void DelimitField<T>(F f, T content)
            where T : ITextual
                => DelimitField(f,content, FieldSep);

        public string Render()
            => State.ToString();

        public void Reset()
            => State.Clear();

        static string rspace(object content)
            => $"{content} ";

        public string Format()
            => State.ToString();
        

        public override string ToString()
            => Format();
    }
}