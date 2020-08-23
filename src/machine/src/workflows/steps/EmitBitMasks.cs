//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using Z0.Data;

    using static Konst;
    using static EmitBitMasksStep;
    using static z;

    using NBI = NumericBaseIndicator;

    public ref struct EmitBitMasks
    {
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitBitMasks(IWfContext context, CorrelationToken ct)
        {
            Wf = context;
            Ct = ct;
            TargetPath = Wf.IndexRoot + FileName.Define("bitmasks", FileExtensions.Csv);;
            Wf.Created(StepName, Ct);
        }

        public void Run()
        {
            Wf.Running(StepName, text.format(RunningPattern, TargetPath), Ct);
            var count = emit(typeof(BitMasks));
            Wf.Ran(StepName, text.format(RanPattern, count, TargetPath), Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        uint emit(Type src)
        {

            var literals = span(find(src));
            var count = literals.Length;
            var formatter = NumericLiteralFormatter.Service;
            using var writer = TargetPath.Writer();
            writer.WriteLine(formatter.HeaderText);

            for(var i=0u; i <count; i++)
            {
                ref readonly var literal = ref skip(literals,i);
                writer.WriteLine(formatter.Format(literal));
            }

            return (uint)count;
        }

        static NumericLiteral[] find(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = new List<NumericLiteral>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(numeric(LiteralAttributes.MultiLiteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(LiteralAttributes.BinaryLiteral(field,vRaw));
                else
                    dst.Add(NumericLiteral.Base2(field.Name, vRaw, Render.bits(vRaw, tc)));
            }
            return dst.ToArray();
        }

        static NumericLiteral[] numeric(LiteralInfo src, object value)
        {
            if(src.MultiLiteral)
            {
                var content = text.unbracket(src.Text);
                if(!text.blank(content))
                {
                    var components = content.SplitClean(Chars.Pipe);
                    var count = components.Length;
                    var dst = sys.alloc<NumericLiteral>(count);
                    for(var i=0; i<components.Length; i++)
                    {
                        var component = components[i];
                        var length = component.Length;
                        if(length > 0)
                        {
                            var indicator = NumericBases.indicator(component[0]);

                            if(indicator != 0)
                                dst[i] = NumericLiteral.Define(src.Name, value, component.Substring(1), NumericBases.kind(indicator));
                            else
                            {
                                indicator = NumericBases.indicator(component[length - 1]);
                                indicator = indicator != 0 ? indicator : NBI.Base2;
                                dst[i] = NumericLiteral.Define(
                                    src.Name,
                                    value,
                                    component.Substring(0, length - 1),
                                    NumericBases.kind(indicator)
                                    );
                            }
                        }
                        else
                            dst[i] = NumericLiteral.Empty;
                    }
                }
            }
            return sys.empty<NumericLiteral>();
        }
    }
}