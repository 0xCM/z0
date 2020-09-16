//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using FK = AsmFragmentKind;

    [ApiHost]
    public readonly struct AsmFragmentWriter// : IAsmFragmentWriter
    {
        const MethodImplOptions Options = MethodImplOptions.NoInlining;

        readonly MemoryAddress Base;

        readonly ITextBuffer Target;

        [MethodImpl(Options), Op]
        public AsmFragmentWriter(MemoryAddress @base, ITextBuffer target)
        {
            Base = @base;
            Target = target;
        }

        [MethodImpl(Options), Op]
        string FormatLabelAddress(string src)
        {
            var hex = HexScalarParser.parse(src).ValueOrDefault();
            return (hex - (ulong)Base).FormatSmallHex(true);
        }

        [MethodImpl(Options), Op]
        public void WriteDirective(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteLabelAddress(string src)
            => Target.Write(FormatLabelAddress(src));

        [MethodImpl(Options), Op]
        public void WritePrefix(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteLabel(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteMnemonic(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteKeyword(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteOperator(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteRegister(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteDecorator(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteData(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteFunctionAddress(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteSelectorValue(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteFunction(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteNumber(string src)
            => Target.Write(src);

        [MethodImpl(Options), Op]
        public void WriteText(string src)
            => Target.Write(src);

        [Op]
        public void Write(string src, AsmFragmentKind kind)
        {
            switch(kind)
            {
                case FK.LabelAddress:
                    WriteLabelAddress(src);
                    break;
                case FK.Directive:
                    WriteDirective(src);
                    break;
                case FK.Prefix:
                    WritePrefix(src);
                    break;
                case FK.Mnemonic:
                    WriteMnemonic(src);
                    break;
                case FK.Keyword:
                    WriteKeyword(src);
                    break;
                case FK.Operator:
                    WriteOperator(src);
                    break;
                case FK.Register:
                    WriteRegister(src);
                    break;
                case FK.Decorator:
                    WriteDecorator(src);
                    break;
                case FK.FunctionAddress:
                    WriteFunctionAddress(src);
                    break;
                case FK.Data:
                    WriteData(src);
                    break;
                case FK.SelectorValue:
                    WriteSelectorValue(src);
                    break;
                case FK.Function:
                    WriteFunction(src);
                    break;
                case FK.Label:
                    WriteLabel(src);
                    break;
                case FK.Number:
                    WriteNumber(src);
                    break;
                default:
                    WriteText(src);
                break;
            }
        }
    }
}