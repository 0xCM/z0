//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using T = AsmGenTarget;

    using static core;
    using static CsPatterns;

    [ApiHost]
    public sealed partial class AsmGen : AppService<AsmGen>
    {
        const string InstructionContractName = nameof(ITypedInstruction);

        const string InlineAttributeSpec = "[MethodImpl(Inline)]";

        const string InlineOpAttributeSpec = "[MethodImpl(Inline), Op]";

        [Op]
        public void GenerateModelsInPlace(ReadOnlySpan<string> src)
        {
            var flow = Wf.Running();
            EmitInstructionContracts(GetTargetPath(T.InstructionContracts));
            EmitMonicExpressions(src, GetTargetPath(AsmGenTarget.MonicExpression));
            EmitMonicEnum(src, GetTargetPath(AsmGenTarget.MonicCodeEnum));
            EmitInstructionTypes(src,GetTargetPath(T.InstructionTypes));
            EmitStatementBuilder(src, GetTargetPath(T.StatementBuilder));
            Wf.Ran(flow);
        }

        public uint GenRegNameProvider(uint margin, ITextBuffer dst)
        {
            const string ProviderName = "AsmRegNames";
            dst.IndentLine(margin, PublicReadonlyStruct(ProviderName));
            dst.IndentLine(margin, Open());
            margin +=4;
            var counter = 0u;
            var types = typeof(AsmRegCodes).GetNestedTypes().Enums().ToReadOnlySpan();
            for(var i=0; i<types.Length; i++)
            {
                ref readonly var type = ref skip(types,i);
                var fields = type.LiteralFields().ToReadOnlySpan();
                for(var j=0; j<fields.Length; j++)
                {
                    ref readonly var field = ref skip(fields,i);
                    var name = field.Name;
                    var tag = field.Tag<SymbolAttribute>();
                    var symbol = text.ifempty(tag.MapValueOrDefault(t => t.Symbol, name),name);
                    var func = PublicOneLineFunc(String(), symbol, Empty(), RP.enquote(symbol));
                    dst.IndentLine(margin, func);
                    dst.AppendLine();
                    counter++;
                }
            }
            margin -=4;
            dst.IndentLine(margin, Close());
            return counter;
        }

        public void GenNameProvider(uint margin, ClrEnumAdapter src, ITextBuffer dst)
        {

        }

        [Op]
        public void GenerateModelsInPlace()
        {
            GenerateModelsInPlace(LoadMnemonicNames());
        }

        [Op]
        public void GenerateModels(ReadOnlySpan<string> src, FS.FolderPath dst)
        {
            var flow = Wf.Running();
            EmitInstructionContracts(GetTargetPath(T.InstructionContracts, dst));
            EmitMonicExpressions(src, GetTargetPath(AsmGenTarget.MonicExpression, dst));
            EmitMonicEnum(src, GetTargetPath(AsmGenTarget.MonicCodeEnum, dst));
            EmitInstructionTypes(src, GetTargetPath(T.InstructionTypes, dst));
            EmitStatementBuilder(src, GetTargetPath(T.StatementBuilder, dst));
            Wf.Ran(flow);
        }

        [Op]
        public void GenerateModels(FS.FolderPath dst)
        {
            GenerateModels(LoadMnemonicNames(), dst);
        }

        const byte Indent = 4;

        const string Open = "{";

        const string Close = "}";

        const string ReadOnlyStructDeclPattern = "public readonly struct {0}";

        const string MonicSymbolPattern = "[Symbol(\"{0}\")]";

        const string NamespaceUsingPattern = "using {0}";

        const string NamespaceDeclPattern = "namespace {0}";

        const string TargetNamespaceName = "Z0.Asm";

        const string ImplicitOperatorDeclPattern = "public static implicit operator {0}({1} src) => {2};";

        const string UsingCompilerServices = "using System.Runtime.CompilerServices;";

        const string UsingRoot = "using static Root;";

        const string UsingTypePattern = "using static {0};";


        const string QualifiedAccessPattern = "{0}.{1}";

        const string AsmNamespaceDecl = "namespace Z0.Asm";

        const string ItemAssignPattern = "{0} = {1},";

        const string FieldDeclPattern = "public {0} {1};";

        const string InstructionContractPattern = @"namespace Z0.Asm
{
    public interface {TargetName}
    {
        AsmMnemonicCode Mnemonic {get;}

        AsmHexCode Encoded {get;}
    }

    public interface {TargetName}<T> : {TargetName}
        where T : struct, {TargetName}<T>
    {

    }
}";

    }
}